   M S B A M L   `   `   `  ����D  @Dictionar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dictionar	Dictionar  5   	   %    Dictionar.Administrative_Module   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Dictionar     5   	     � Title$  Administrative_Module��5   	   $	��450��6'   $	��800��64   ��5
      �� 5   
    �� ImageSource$R LC:\Users\vladd\OneDrive\Documents\Facultate\AN 2\MVP\Team 1\Dictionar\bg.jpg��6    j� Stretch$
 Fill=�6p    � DataContext 5        Dictionar.Autocomplete  5   
   6    � 	Resources 5         conv��%!   &	        �� 5   
   5      5      .��5      � .+�5   
   �� $��Modul Administrator��6   $��35(�6.   $��	UltraBold"�6<   
���p�$
��left=�6m   $��
210,45,0,0q�6�   $	��Top=�6�   $	��386��6�   �� 5   
   -   5        $��Inapoi la Meniu��5      $
��Left=�6+   $��	51,45,0,0q�6F   $	��Top=�6Y   $��97��6q   6|   �� 5   
   $
��Left=�62   $��23��6M   $��159,131,0,0q�6Y    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��251��6�   ��6   �� *newWord.text+6�   �� 5   
   -   5         ��Name$ newCat��5      $�� ��6w   $
��Left=�6�   $��23��6�   $��190,167,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��190��6�   y�6"   �� *	IsChecked+ �� ElementName$ Check�� �� 	Converter# [  6�   �� 5   
   $
��Left=�69   $	��186��6T   $��495,128,0,0q�6a   $
 Wrap=�6v   $	��Top=�6�   $	��265��6�   ��6   �� *newWord.description+6�   �� 5   
   -   5        $��Adauga cuvantul��5      $
��Left=�6+   $��339,336,0,0q�6F   $	��Top=�6[   $	��120��6s   $��42��6   6�   �� 5   
   $��Cuvant:��6   $
��Left=�6"   $��
34,128,0,0q�6=   $	��Top=�6Q   �� 5   
   $��Categorie existenta:��6   $
��Left=�6/   $��
34,204,0,0q�6J   $	��Top=�6^   $��29��6v   �� 5   
   $��
Descriere:��6   $
��Left=�6%   $��428,128,0,0q�6@   $	��Top=�6U   	 J� RenderTransformOrigin$	 0.947,0.577&�6m   �� 5    
   -   5        
 ��Name$
 Check��5       $�� ��6"   $
��Left=�6-   $��159,171,0,0q�6H   $	��Top=�6]   $	 1,0.5&�6u   $��19��6�   $��31��6�   �� 5!   
   $
��Left=�6�   $��190,204,0,0q�6�   $	��Top=�6�   $	��190��6  $��23��6  y�6   �� *	IsChecked+$ Check1��# [  ��6i   �� *category_list+ �� SelectedItem 6�   �� *newWord.category+6  �� 5"   
   $��Categorie noua:��6   $
��Left=�6*   $��
34,167,0,0q�6E   $	��Top=�6Y   $	 0.409,0.385&�6q   �� 5#   
   $
��Left=�68   $��62��6S   $��159,252,0,0q�6_   $
 Wrap=�6t   $	��Top=�6�   $	��251��6�   ��6   �� *newWord.picture_path+6�   �� 5$   
   $��Path Imagine:��6   $
��Left=�6(   $��
37,252,0,0q�6C   $	��Top=�6W   �� 5%   
   -   5        $��Modifica un cuvant��5%      $
��Left=�6.   $��210,336,0,0q�6I   $	��Top=�6^   $	��108��6v   $��42��6�   6�   �� 5&   
   -   5        $��Sterge un cuvant��5&      $
��Left=�6,   $��481,336,0,0q�6G   $	��Top=�6\   $��97��6t   $��42��6   6�   �� 5'   
   -   5        $
 Check1��5'      $�� ��6#   $
��Left=�6.   $��159,208,0,0q�6I   $	��Top=�6^   $	 1,0.5&�6v   $��19��6�   $��31��6�   5(      5)      