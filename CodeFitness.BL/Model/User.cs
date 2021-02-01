using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFitness.BL.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    class User
    {
        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get; }
        /// <summary>
        /// День рождения
        /// </summary>
        public DateTime BirthDate { get; }
        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Рост
        /// </summary>
        public double Height { get; set; }
        #endregion
        /// <summary>
        /// Создать нового пользователя
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="gender"> Пол </param>
        /// <param name="birthDate"> День Рождения </param>
        /// <param name="weight"> Вес </param>
        /// <param name="height"> Рост </param>
        public User(string name, Gender gender,
            DateTime birthDate, double weight,
            double height)
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
            }
            if (Gender == null)
            {
                throw new ArgumentNullException("Гендер не может быть пустым", nameof(gender));
            }
            if (birthDate < DateTime.Parse("01.01.1921") || birthDate >= DateTime.Now)
            {
                throw new ArgumentNullException("Дата рождения не может быть пустым", nameof(birthDate));
            }
            if (weight <= 0)
            {
                throw new ArgumentNullException("Вес не может быть пустым", nameof(weight));
            }
            if (height <= 0)
            {
                throw new ArgumentNullException("Рост не может быть пустым", nameof(height));
            }
            #endregion
            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
