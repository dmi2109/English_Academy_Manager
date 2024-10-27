﻿using EnglishAcademyManager_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManager_BUS
{
    public class ScheduleService
    {
        private readonly EnglishAcademyDbContext context = new EnglishAcademyDbContext();

        // Thêm mới lịch học
        public void AddSchedule(ScheduleDetails schedule)
        {
            context.ScheduleDetails.Add(schedule);
            context.SaveChanges();
        }

        // Cập nhật lịch học
        public void UpdateSchedule(ScheduleDetails schedule)
        {
            var existingSchedule = context.ScheduleDetails.Find(schedule.schedule_id);
            if (existingSchedule != null)
            {
                existingSchedule.start_time = schedule.start_time;
                existingSchedule.end_time = schedule.end_time;
                existingSchedule.room = schedule.room;
                existingSchedule.class_id = schedule.class_id;

                context.SaveChanges();
            }
        }

        // Xóa lịch học
        public void DeleteSchedule(string scheduleId)
        {
            var schedule = context.ScheduleDetails.Find(scheduleId);
            if (schedule != null)
            {
                context.ScheduleDetails.Remove(schedule);
                context.SaveChanges();
            }
        }

        // Lấy toàn bộ lịch học
        public List<ScheduleDetails> GetAllSchedules()
        {
            return context.ScheduleDetails.ToList();
        }

        // Lấy lịch học theo ID
        public ScheduleDetails GetScheduleById(string scheduleId)
        {
            return context.ScheduleDetails.Find(scheduleId);
        }

        // Hiển thị lịch học theo tuần
        public List<ScheduleDetails> GetSchedulesByWeek(DateTime startOfWeek)
        {
            DateTime endOfWeek = startOfWeek.AddDays(7);
            return context.ScheduleDetails
                .Where(s => s.start_time >= startOfWeek && s.start_time < endOfWeek)
                .ToList();
        }

        // Hiển thị lịch học theo ca (thời gian trong ngày)
        public List<ScheduleDetails> GetSchedulesByTimeRange(TimeSpan startTime, TimeSpan endTime)
        {
            return context.ScheduleDetails
                          .Where(s => s.start_time.HasValue && s.end_time.HasValue &&
                                      s.start_time.Value.TimeOfDay >= startTime &&
                                      s.end_time.Value.TimeOfDay <= endTime)
                          .ToList();
        }


    }
}
