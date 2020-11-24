using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ExpenseManager;

namespace ExpenseManagerWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseDetailController : ControllerBase
    {
        private ExpenseSystem _theExpenseSystem;
        public ExpenseDetailController(ExpenseSystem expense)
        {
            _theExpenseSystem=expense;
        }

        [HttpGet]
        public List<ExpenseDetail> ViewExpense()
        {
            List<ExpenseDetail> results = _theExpenseSystem.ViewAllExpense();
            return results;
        }

        [HttpPost]
        public string AddExpense(ExpenseDetail expense)
        {
            _theExpenseSystem.AddNewExpense(expense);
            return "expense added successfully";
        }

        [HttpPut]
        public string UpdateExpense(Guid id, Double amount)
        {
            _theExpenseSystem.UpdateEachExpense(id,amount);
            return "expense updated successfully";
        }

        [HttpDelete]
        public string DeleteExpense(Guid id)
        {
            _theExpenseSystem.DeleteEachExpense(id);
            return "expense deleted successfully";
        }
    }
}
