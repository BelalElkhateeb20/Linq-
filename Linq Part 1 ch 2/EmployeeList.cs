using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Part_1_ch_2
{
    public class EmployeeList :IEnumerable
    {
        private int id; 
        private decimal salary; 
        private string name;
        List<EmployeeList> lst = new List<EmployeeList>();
        
        public List<EmployeeList>  GetEmployeeLists()
        {
            EmployeeList employeeList = new EmployeeList
            {
                id = 1,
                name = "belal",
                salary = 2001m
            };
            lst.Add(employeeList);

            employeeList = new EmployeeList
                            
             {
               id = 2,
               name = "Mohamed",
               salary = 3000m
             };
            lst.Add(employeeList);

            employeeList = new EmployeeList

            {
                id = 3,
                name = "somaya",
                salary = 1500m
            };
            return lst;
        }
    
        public EmployeeList()
        {
            
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
