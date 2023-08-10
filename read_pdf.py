import PyPDF2
import pdfplumber


pdf_file = 'EPL22-23.pdf'


#  Использовал библиотеку PyPDF2 для излечение всей информации
with open(pdf_file, 'rb') as file:
    pdf_reader = PyPDF2.PdfReader(file)  # Читаем весь файл
    num_pages = len(pdf_reader.pages)  # Записываем количества страниц

    for page_num in range(num_pages):
        # Проходим циклов по страницам
        page = pdf_reader.pages[page_num]
        text = page.extract_text()
        print(text)


# Использовал библиотеку pdfplumber для извлечение определенной информации
with pdfplumber.open(pdf_file) as pdf:
    page = pdf.pages[0]  # Выбираем первую страницу (индекс 0)
    table = page.extract_tables()[0]  # Извлекаем таблицы и выбираем первую

    # Выбираем 5-ую строку (индекс 4) и 4-ый столбец (индекс 3)
    selected_cell = table[4][3]
    print(selected_cell)
