נושא: מרפאת שיניים

תיאור הפרויקט: 
מערכת לניהול תורים לתחנת מרפאת שיניים, באמצעות המערכת ניתן להזמין תור לרופא ולנהל את כלל התורים בתחנה.

ישויות:
לקוח
רופא
תור

מיפוי Routes ללקוח:
שליפת רשימת הלקוחות Get('https://MeuhedetDentist.co.il/clients ') 
שליפת תינוק לפי מזהה  Get('https://MeuhedetDentist.co.il/clients/{id} ') 
הוספת לקוח PUT('https://MeuhedetDentist.co.il/clients ') 
עדכון לקוח POST('https://MeuhedetDentist.co.il/clients/{id } ')

מיפוי Routes לרופאים: 
שליפת רשימת הרופאים Get('https://MeuhedetDentist.co.il/doctors ') 
שליפת רופא לפי מזהה Get('https://MeuhedetDentist.co.il/doctors/{id} ') 
הוספת רופא PUT('https://MeuhedetDentist.co.il/doctors ') 
עדכון רופא POST('https://MeuhedetDentist.co.il/doctors/{id} ') 

מיפוי Routes לרופאים: 
שליפת רשימת התורים Get('https://MeuhedetDentist.co.il/turns ') 
שליפת תור לפי מזהה  Get('https://MeuhedetDentist.co.il/turns/{id} ') 
הוספת תורPUT('https://MeuhedetDentist.co.il/turns') 
עדכון תור POST('https://MeuhedetDentist.co.il/turns/{id} ') 
מחיקת תור DELETE('https://MeuhedetDentist.co.il/turns/{id} ')

בחרתי לא למפות Routes למחיקת תינוק ואחות. במקום זה אוסיף Routes לעדכון סטטוס:
PUT('https://MeuhedetDentist.co.il/clients/{id}/status') 
PUT('https://MeuhedetDentist.co.il/doctors/{id}/status')
