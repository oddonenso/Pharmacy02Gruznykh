   M S B A M L   `   `   `  ���� C  ?Pharmacy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Pharmacy.PagesPharmacy.Pages      Pharmacy.Pages.Admin   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     .localclr-namespace:Pharmacy.Pages       N� Title$  Admin��$	��500��$	��800�� N� 
Background
 �����.���  � ColumnDefinitions �� $	��200 ��� $	��200 ��� $	��200 ��� $��* � � RowDefinitions �� $��56 ��� �� $��30 �.+��� -   $��	txtSearch��$��0��$��0��$��Center=�$��
5, 0, 5, 0q��� -   $��
cmbSorting�����#a01c1b$��0��$��1�� �� SelectedIndex$ 0��$��Center=�$��
5, 0, 5, 0q�.@��� ���#a01c1b
�������По возрастанию�� ���#a01c1b
�������По убыванию�� -   $��	cmbFilter�����#a01c1b���#83050b$��2q�$��0��$��2��$ 0��$��
5, 0, 5, 0q�$��Center=�.@��� ���#a01c1b
�������Должность�� ���#a01c1b
�������Фамилия�� ���#a01c1b
�������Имя�� ���#a01c1b
�������Отчество�� -   $/��)Добавить пользователя��$��0��$��3��$��
5, 0, 5, 0q�$��Center=��� -    ��Name$ LViewPpl��$��5q�$��0��$��4��$��
2,44,27,22q�$��Disabled=�$��2������  �� View �� .P��� $��Photo�� �� CellTemplate �� .R��� $��50��$��50������ *Photo+�� $
��Name�� �� DisplayMemberBinding �� *Name+�� $��Surname�� �� *	Surname+�� $��
Patronymic�� �� *
Patronymic+