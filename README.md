# C-Adv-Exercises-Q1
Q1 from the C# Adv exercises to prep for the exam

Section A – Windows Forms Applications
Exercise 1

Create a Windows Form Application that will read and write from text files, using a BufferedStream.
The Windows Form Application should look like the following:
![image](https://github.com/KonceptD/C-Adv-Exercises-Q1/assets/94140236/92f07323-c91a-4688-acdc-a756af99810e)

When the Windows Form Application loads, the days of the week (such as Monday, Tuesday, etc) should be inserted
into an ArrayList, and then the ListBox must be populated with the values in the ArrayList.

When the user selects a day of the week, the respective text file with the same name as the weekday (such as
‘Monday.txt’ for ‘Monday’) must be read and its contents filled into the TextBox control (which must be MultiLine’d and
WordWrap’d)

The user must be allowed to edit the contents in the TextBox control, and when the ‘Save’ button is pressed, the
contents in the TextBox control must be written to the currently selected text file, truncating the existing contents in
that file.

