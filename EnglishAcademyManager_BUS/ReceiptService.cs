using EnglishAcademyManager_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishAcademyManager_BUS
{
    public class ReceiptService
    {
        private readonly EnglishAcademyDbContext _dbContext;

        public ReceiptService(EnglishAcademyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // Thêm hóa đơn
        public void AddReceipt(Receipt receipt)
        {
            ValidateReceipt(receipt);
            _dbContext.Receipt.Add(receipt);
            _dbContext.SaveChanges();
        }

        // Cập nhật hóa đơn
        public void UpdateReceipt(Receipt receipt)
        {
            ValidateReceipt(receipt);
            var existingReceipt = _dbContext.Receipt.Find(receipt.receipt_id);
            if (existingReceipt == null)
                throw new KeyNotFoundException("Receipt not found.");

            existingReceipt.student_id = receipt.student_id;
            existingReceipt.amount = receipt.amount;
            existingReceipt.payment_date = receipt.payment_date;
            _dbContext.SaveChanges();
        }

        // Xóa hóa đơn
        public void DeleteReceipt(string receiptID)
        {
            var receipt = _dbContext.Receipt.Find(receiptID);
            if (receipt == null)
                throw new KeyNotFoundException("Receipt not found.");

            _dbContext.Receipt.Remove(receipt);
            _dbContext.SaveChanges();
        }

        // Lấy danh sách hóa đơn
        public List<Receipt> GetAllReceipts()
        {
            return _dbContext.Receipt.ToList();
        }

        // Lấy hóa đơn theo ID
        public Receipt GetReceiptById(string receiptID)
        {
            var receipt = _dbContext.Receipt.Find(receiptID);
            if (receipt == null)
                throw new KeyNotFoundException("Receipt not found.");
            return receipt;
        }

        // Kiểm tra và xác thực dữ liệu
        private void ValidateReceipt(Receipt receipt)
        {
            if (string.IsNullOrEmpty(receipt.student_id))
                throw new ArgumentException("Student ID is required.");
            if (receipt.amount <= 0)
                throw new ArgumentException("Amount must be greater than zero.");
            if (receipt.payment_date == default(DateTime))
                throw new ArgumentException("Payment date is required.");
        }
    }
}


