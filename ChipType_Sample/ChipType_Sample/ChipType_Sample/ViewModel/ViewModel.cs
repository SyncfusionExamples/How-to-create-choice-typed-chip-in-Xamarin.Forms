using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChipType_Sample
{
        public class ViewModel
        {
            public ViewModel()
            {
                ChoiceItems = new ObservableCollection<Model>()
                {
                    new Model()
                    {
                        PersonName = "MEN",
                        PersonImage = ImageSource.FromResource("ChipType_Sample.Mens.Image2.jpg"),
                        CategoryImage = new ObservableCollection<ImageSource>()
                        {
                            ImageSource.FromResource("ChipType_Sample.Mens.Image1.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Mens.Image2.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Mens.Image3.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Mens.Image4.jpg")
                        }
                    },
                    new Model()
                    {
                        PersonName = "WOMEN",
                        PersonImage = ImageSource.FromResource("ChipType_Sample.Girls.Image2.png"),
                        CategoryImage = new ObservableCollection<ImageSource>()
                        {
                            ImageSource.FromResource("ChipType_Sample.Girls.Image1.png"),
                            ImageSource.FromResource("ChipType_Sample.Girls.Image2.png"),
                            ImageSource.FromResource("ChipType_Sample.Girls.Image3.png"),
                            ImageSource.FromResource("ChipType_Sample.Girls.Image4.png"),
                            ImageSource.FromResource("ChipType_Sample.Girls.Image5.png")
                        }
                    },
                    new Model()
                    {
                        PersonName = "KIDS",
                        PersonImage = ImageSource.FromResource("ChipType_Sample.Kids.download.jpg"),
                        CategoryImage=new ObservableCollection<ImageSource>
                        {
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid1.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid2.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid3.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid4.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid5.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Kids.Kid6.jpg")
                        }
                    },
                    new Model()
                    {
                        PersonName = "BEAUTY",
                        PersonImage = ImageSource.FromResource("ChipType_Sample.Makeup.4.jpg"),
                        CategoryImage=new ObservableCollection<ImageSource>()
                        {
                            ImageSource.FromResource("ChipType_Sample.Makeup.1.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Makeup.2.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Makeup.3.jpg"),
                            ImageSource.FromResource("ChipType_Sample.Makeup.4.jpg")
                        }
                    }
                };
            }


            public ObservableCollection<Model> ChoiceItems
            {
                get; set;
            }

        }
}
