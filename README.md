1. __Развертывание среды python__  
   Для начало надо установить python  
   Для создания виртуального окружения  
       `python -m venv myenv`   
   Для активации виртуального окружения  
       `source myenv/bin/activate`    
   Установка библиотек с помощью pip  
       `pip install _name_`  
   Создание файла для записи библиотек  
       _requirements.txt_  
   При развертывание проекта на другом компьютере, выполните следующие действия:  
   - Клонируйте ваш репозиторий с кодом (если используете систему контроля версий).  
   - Создайте виртуальное окружение и активируйте его.  
   - Установите зависимости из файла requirements.txt  
       `pip install -r requirements.txt`    

2. __Чтение данных из PDF файла Python - взять электронный документ в формате PDF и вычитать данные через python__  
       _read_pdf.py_ 
   Импортировал библиотеки  
       `pip install PyPDF2`  
       `pip install pdfplumber`  
   для работы с файлами PDF.  

   Здесь показано, как использовать две разные библиотеки с одним файлом  
   Использовал библиотеку PyPDF2 для чтение документа полностью  
   А библиотеку pdfplumber использовал чтобы взять определенную информацию  

3. __мини-приложение на C#__  
       _mini_app.cs_  
   Создал игру Камень-Ножница-Бумага языке C#  
   Играете против компьютера.  
   В игре юзеру надо вводить к, н, б или в чтобы выйти.  
   После игры появляется счет.  



