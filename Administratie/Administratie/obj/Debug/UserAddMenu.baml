   M S B A M L   `   `   `  ����H  DAdministratie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AdministratieAdministratie  5   	       Administratie.UserAddMenu   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Administratie     5   	   -   5        ���#2D2D2F  � Title$  UserAddMenu��5   	   $	��304��6   $	��748��6*   .��5	      � $��0,0,0,-6q�6    � ColumnDefinitions 5
   
   �� 5      $
��517* �6   �� 5      $
��283* �6   .+�5   
   �� -   5         ��Name$ label��5      $��Email:��6   $
��Left=�60   $��	10,14,0,0q�6K   $	��Top=�6^   
�������$��20(�6�   �� 5   
   -   5        $ 
label_Copy��5      $��Naam:��6$   $
��Left=�64   $��	10,65,0,0q�6O   $	��Top=�6b   
�������$��20(�6�    J� RenderTransformOrigin$ 0.566,-0.351&�6�   �� 5   
   -   5        $ label_Copy1��5      $��Achternaam:��6%   $
��Left=�6;   $��
10,110,0,0q�6V   $	��Top=�6j   
�������$��20(�6�   �� 5   
   -   5        $ label_Copy2��5      $��Telefoonnummer:��6%   $
��Left=�6?   $��199,1130,0,0q�6Z   $	��Top=�6p   
�������$��20(�6�   $��1��6�   �� 5   
   -   5        $ label_Copy3��5      $��	Postcode:��6%   $
��Left=�69   $��
10,231,0,0q�6T   $	��Top=�6h   
�������$��20(�6�   �� 5   
   -   5         ��Name$ emailTextBox��5      $
��Left=�6(   $��
207,23,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��262��6�   �� 5   
   -   5        $ nameTextBox��5      $
��Left=�6'   $��
207,74,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��261��6�   �� 5   
   -	   5        $ sureNameTextBox��5      $
��Left=�6+   $��207,119,0,0q�6F   $
 Wrap=�6[   $	��Top=�6o   $	��261��6�   �� 5   
   -
   5        $ postalCodeTextBox��5      $
��Left=�6-   $��207,240,0,0q�6H   $
 Wrap=�6]   $	��Top=�6q   $	��262��6�   �� 5   
   -   5         ��Name$ createButton��5      $��1��6'   $��Aanmaken��67   $��Center=�6J   $��0,40,0,0q�6g   $	��Top=�6y   $	��140��6�   6�   �� 5   
   -   5        $ 
backButton��5      $��1��6%   $��Terug��65   $��Center=�6E   $��	0,221,0,0q�6b   $	��Top=�6u   $	��140��6�   6�   �� 5   
   -   5        $ label_Copy4��5      $��Telefoonnummer:��6%   $
��Left=�6?   $��
10,170,0,0q�6Z   $	��Top=�6n   
�������$��20(�6�   �� 5   
   -   5        $ cellPhoneTextBox��5      $
��Left=�6,   $��207,179,0,0q�6G   $
 Wrap=�6\   $	��Top=�6p   $	��261��6�   5      5      