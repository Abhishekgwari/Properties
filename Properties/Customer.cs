using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Customer
    {
       int _Custid;
        bool _Status;
        string _Cname,_State;
        double _Balance;
        cities _city;
       
        public Customer(int Custid, bool Status,string Cname, double Balance,cities City, string State)
        {
            _Custid = Custid;   
            _Status = Status;
           _Cname = Cname;
            _Balance = Balance;
            _city = City;
            _State = State; 
    
        }
        public int Custid
        {
            get { return _Custid; }
            set { _Custid = value; }
        }
        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }

        }

        public string Cname
        {
            get { return _Cname; }
           set {
                if(_Status == true)
                    _Cname = value; }
        }
        
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value >= 500)

                    _Balance = value;
                }
        }
        }
       public cities City

        {
            get { return _city; }

            set
            {
                if (_Status == true)
                    _city = value;
            }

        }
        public String State
        {
            get { return _State; }
            protected set
            {
                if (_Status == true)
                    _State = value;
            }
        }
        public String Country                  // Auto implemented or Automatic property (3.0 version)
        {                                       //Auto property initializer
            get;
            set;
        } = "India";
        
        }

        }
  
    

