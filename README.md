# Coffee-Machine![Screenshot 2025-02-02 002604](https://github.com/user-attachments/assets/ec598b92-0aef-4e49-ae3d-017bedc08c75)
# เครื่องขายกาแฟอัตโนมัติ (Coffee Vending Machine)

## 🎯 รายละเอียดการออกแบบ
เครื่องขายกาแฟอัตโนมัติสามารถทำเครื่องดื่มได้หลายประเภท เช่น ลาเต้ กาแฟดำ และน้ำเปล่า รวมถึงสามารถเติมสต็อกวัตถุดิบได้

---

## 🖼️ UML Class Diagram

```mermaid
classDiagram
    class CoffeeMachine {
        - int Water
        - int Coffee
        - int Milk
        - int Sugar
        + CoffeeMachine(int, int, int, int)
        + string MakeLatte(int)
        + string MakeBlackCoffee(int)
        + string PlainMilk(int)
        + string PlainWater(int)
        + string ShowStock()
        + void IncreaseStock(int, int, int, int)
    }

    class Form1 {
        - CoffeeMachine machine
        - Label lblStatus
        + Form1()
    }

    Form1 --> CoffeeMachine : ใช้งาน

---

## **🔥 คำอธิบาย Class Diagram**
1. **CoffeeMachine** (คลาสหลัก)  
   - มีตัวแปรเก็บสต็อกของ **น้ำ, กาแฟ, นม, น้ำตาล**  
   - มีเมธอดสำหรับทำ **ลาเต้, กาแฟดำ, นมเปล่า, น้ำเปล่า**  
   - มีฟังก์ชัน **ShowStock()** สำหรับดูปริมาณวัตถุดิบ  
   - มีเมธอด **IncreaseStock()** สำหรับเติมวัตถุดิบ  

2. **Form1** (UI ของโปรแกรม)  
   - มีตัวแปร `CoffeeMachine machine` เพื่อเชื่อมกับเครื่องขายกาแฟ  
   - มีป้ายแสดงข้อความ `lblStatus`  
   - มีการเรียกใช้ `CoffeeMachine` เมื่อกดปุ่ม  

---

## **📌 วิธีใช้งาน**
1. กดปุ่ม `ทำลาเต้` หรือ `ทำกาแฟดำ` เพื่อทำกาแฟ  
2. กด `แสดงสต็อก` เพื่อตรวจสอบปริมาณวัตถุดิบ  
3. กด `เติมสต็อก` เพื่อเติมวัตถุดิบกลับไปเต็ม  

---

## 🎯 **เป้าหมายของโปรเจค**
- ออกแบบเครื่องขายกาแฟที่ใช้งานได้จริง  
- มี UI ที่สวยงาม  
- ใช้ **UML Class Diagram** เพื่อช่วยอธิบายการทำงาน  

---
