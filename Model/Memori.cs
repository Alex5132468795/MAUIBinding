using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp5.Model
{
    public class Memori : INotifyPropertyChanged
    {

        //public string text;

        //public event PropertyChangedEventHandler PropertyChanged;
        //public string Text
        //{
        //    get
        //    {
        //        return text;
        //    }
        //    set{
        //        text = value;
        //        OnPropertyChanged();
        //    }
        //}
        //protected void OnPropertyChanged([CallerMemberName] string tt=null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tt));
        //}
        //public string this[int index]
        //{
        //    get { return this[index]; }

        //}
        //--------------------------------------------------------------------------
        public string name;
        public string secondName;
        public string fami;
        public string sour; 

        public event PropertyChangedEventHandler PropertyChanged;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }
        public string SecondName
        {
            get
            {
                return secondName;
            }
            set
            {
                secondName = value;
                OnPropertyChanged();
            }
        }
        public string Fami
        {
            get
            {
                return fami;
            }
            set
            {
                fami = value;
                OnPropertyChanged();
            }
        }
        public string Sour
        {
            get
            {
                return sour;
            }
            set
            {
                sour = value;
                OnPropertyChanged();
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string tt = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(tt));
        }
        public string this[int index]
        {
            get { return this[index]; }

        }
    }
}
