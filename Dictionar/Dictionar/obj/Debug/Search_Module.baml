   M S B A M L   `   `   `  ����D  @Dictionar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dictionar	Dictionar  5   	       Dictionar.Search_Module   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Dictionar     5   	     � Title$  Search_Module��5   	   $	��450��6   $	��800��6,   ��5	      �� 5
   
    �� ImageSource$R LC:\Users\vladd\OneDrive\Documents\Facultate\AN 2\MVP\Team 1\Dictionar\bg.jpg��6    j� Stretch$
 Fill=�6p    � DataContext 5        Dictionar.Autocomplete  5   
   .��5      � .+�5   
   �� -   5        $��textBox��5   =   $��
5, 3, 5, 3q�6   $��70,150,524.6,233q�6L   �� 5   
   
���   �$��1q�6%   $y�Hidden=�69   $��70,179,525,133q�6M   ._�5      �� $��Hidden=�6   $��	-1,1,-1,9q�6@   .��5      �� -   5        $��resultStack��5      62   5      5      �� 5   
   $��Modul Cautare��6   $��35(�6(   $��	UltraBold"�66   
���p�$
��left=�6g   $��
251,30,0,0q�6�   $	��Top=�6�   $	��267��6�   �� 5   
   $
��Left=�6   $��37��6+   $��
33,150,0,0q�67   $	��Top=�6K   $��32��6c    J� RenderTransformOrigin$ -0.062,0.98&�6n   $[��UC:\Users\vladd\OneDrive\Documents\Facultate\AN 2\MVP\Team 1\Dictionar\search_icon.png��6�   �� 5   
   -   5        $��Inapoi la Meniu��5      $
��Left=�6+   $��	53,37,0,0q�6F   $	��Top=�6Y   $��93��6q   6|   �� 5   
   -   5         �� SelectedIndex$ 0��5      $
��Left=�6u   $��
93,102,0,0q�6�   $	��Top=�6�   $	��169��6�   $��29��6�   ��6%   �� *category_list+ �� SelectedItem 6K   �� *newWord.category+6�   �� 5   
   $��
Categorie:��6   $
��Left=�6%   $��
32,102,0,0q�6@   $	��Top=�6T   �� 5   
   -   5         ��Name$ descript��5      $
��Left=�6$   $��93��6?   $��390,102,0,0q�6K    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��332��6�   �� 5   
   -   5        	 ��Name$	 Picture��5      $
��Left=�6!   $
��Fill=�6<   $	��131��6K   $��475,209,0,0q�6X   $	��Top=�6m   $	��171��6�   $i��cC:\\Users\\vladd\\OneDrive\\Documents\\Facultate\\AN 2\\MVP\\Team 1\\Dictionar\\default_picture.png��6�   �� 5   
   $��
Descriere:��6   $
��Left=�6%   $��312,105,0,0q�6@   $	��Top=�6U   �� 5   
   $��Imagine:��6   $
��Left=�6#   $��411,251,0,0q�6>   $	��Top=�6S   5       5!      