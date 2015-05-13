using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace My_db
{
    #region Table
    public class Table
    {
        #region Member Variables
        protected string _Username;
        protected string _Password;
        protected string _Role;
        #endregion
        #region Constructors
        public Table() { }
        public Table(string Username, string Password, string Role)
        {
            this._Username=Username;
            this._Password=Password;
            this._Role=Role;
        }
        #endregion
        #region Public Properties
        public virtual string Username
        {
            get {return _Username;}
            set {_Username=value;}
        }
        public virtual string Password
        {
            get {return _Password;}
            set {_Password=value;}
        }
        public virtual string Role
        {
            get {return _Role;}
            set {_Role=value;}
        }
        #endregion
    }
    #endregion
}