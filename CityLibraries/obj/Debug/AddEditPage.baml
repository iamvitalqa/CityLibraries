   M S B A M L   `   `   `  ����H  DCityLibraries, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CityLibrariesCityLibraries  5          CityLibraries.AddEditPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:CityLibraries     5        N� Title$  AddEditPage��5	       N� 
FontFamily$ Comic Sans MS)�6   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $	��100 �6   6+   �� 5      $��50 �6   6*   .+�5   
   �� $��0��6   $��Фамилия: ��6!   $��Right=�62   $��Center=�6N   $��20(�6i   6z   �� 5   
   $��1��62   $��0��6B   $
��Left=�6O   ��6   �� *READER_SURNAME+6l   �� 5   
   $��1��6   $��Имя: ��6!   $��Right=�6.   $��20(�6J   $��Center=�6X   6v   �� 5   
   $��1��6/   $��1��6?   $
��Left=�6L   ��6   �� *READER_NAME+6i   �� 5   
   $��2��6   $��Отчество: ��6!   $��Right=�63   $��20(�6O   $��Center=�6]   6{   �� 5   
   $��1��65   $��2��6E   $
��Left=�6R   ��6   �� *READER_PATRONYMIC+6o   �� 5    
   $��3��6   $!��Дата рождения: ��6!   $��Right=�68   $��20(�6T   $��Center=�6b   6�   :  4System.Windows.Controls.Primitives.DatePickerTextBox  5!   
   $��3��6S   $��1��6`   $��20(�6p   $��40��6~   $	��110��6�   $
��Left=�6�   ��6   �� *READER_BIRTHDAY+ �� StringFormat$ {0:d}��6�   �� 5"   
   $��4��6   $*��$Место работы/учёбы: ��6!   $��Right=�6=   $��20(�6Y   $��Center=�6g   6�   �� 5#   
   $��1��68   $��4��6H   $
��Left=�6U   ��6   �� *READER_WORKING_PLACE+6r   �� 5$   
   $��6��6   $��Right=�6!   $��Center=�6=   $��
Фото: ��6X   $��20(�6f   $��5q�6u   6�   �� 5%   
   $��1��6   $��5��6%    �� Orientation$ Vertical=�62   $��3��6I   .+�5&      �� -   5        $��	LogoImage��5&      $��UniformToFill=�6&   $��50��6>   $	��100��6M   $	��100��6Z   $
��Left=�5'      $��5q�60   ��5(      �� 5)       �� Path$ READER_PHOTO�6    �� TargetNullValue 5*      ��5+      Resources\picture.png��5-      5/      51      �� 52      -   5        $��ChangePictureBtn��52   C   $��Изменить��6   $
��Left=�6(   6|   53      �� 54   
   -   5        $��
saveButton��54   .   $��1��6   $��9��6!   $��Сохранить��6Y   $
��Left=�6m   6�   �� 55   
   -   5        $��
backButton��55   .   $��0��6   $��9��6!   $��
Назад��6Y   $��Right=�6j   6�   56      57      