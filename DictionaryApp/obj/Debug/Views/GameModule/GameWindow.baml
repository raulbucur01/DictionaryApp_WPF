   M S B A M L   `   `   `  ����H  DDictionaryApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:DictionaryApp.Views.GameModuleDictionaryApp.Views.GameModule  5   	   /    )DictionaryApp.Views.GameModule.GameWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:DictionaryApp.Views.GameModule     5   	     � WindowStartupLocation$  CenterOwner=�5   	    � Title$	 Joc��5	   	   $	��450��6   $	��800��6"    � 
ResizeMode$ NoResize=�5
   	   .��5      � ���	#FFB1CAF9.+�5   
   �� -   5        $��startStackPanel��5      $��Center=�6,   $y�Visible=�6G   .+�5      �� -   5        $��welcomeLabel��5      $��Joc de ghicit cuvinte��6(   $��50��6H   $	��280��6T   $��30(�6`   $��30q�6n   �� 5      -   5        $��startBtn��5      $��50��6%   $	��150��61   $��START��6=   $��30(�6M   $��30q�6[   5      5      � 5   
   -   5        $��gameGrid��5      $y�	Collapsed=�6   .+�5      �� -   5        $��gameStatusLabel��5      $��Ghiceste cuvintele:��6+   $��25(�6I   $��10,10,543,347q�6W   �� 5      -   5        $��amountGuessedLabel��5      $��Ghicite: 0/5��6.   $��25(�6E   $��624,10,10,347q�6S   �� 5      -   5        $��
roundLabel��5      $��Runda: 0��6&   $��25(�69   $��624,49,10,308q�6G   �� 5      -   5        $��	clueLabel��5      $��	Indiciu: ��6%   $	��Top=�69   $��90,129,599,0q�6Q   $��67��6g   $��25(�6s   �� 5      -	   5        $��	clueImage��5      $	��180��6%   $	��180��63   $��303,72,317,182q�6?   $y�	Collapsed=�6W   $��UniformToFill=�5      �� 5      -
   5        $��clueRectangle��5      $
��Left=�6.   $	��105��6I   $��206,112,0,0q�6V   
���   �$	��Top=�5    '   $	��426��6?   $y�	Collapsed=�6K   �� 5!      -   5        $��
clueTblock��5!      $
��Wrap=�6*   $��206,112,168,219q�6>   $��20(�5"      $y�	Collapsed=�6&    �� TextAlignment$ Center=�6=   $��Center=�6T   �� 5$      -   5        $��nextBtn��5$      $
��Next��6$   $
��Left=�63   $��658,336,0,0q�6N   $	��Top=�5&      $��98��6-   $��42��68   {�.  $��16(�6V   �� 5(      -   5        $��	verifyBtn��5(      $��Verify��6&   $
��Left=�67   $��533,336,0,0q�6R   $	��Top=�5*      $��99��6-   $��42��68   $��16(�6D   �� 5,      -   5        $��guessTb��5,      $
��Left=�6%   $��208,324,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�5-      $	��192��6.   $��54��6:   $��20(�6F    �� TextAlignment$ Center=�6T   �� 5.      $��Raspuns:��6   $
��Left=�6'   $��
90,325,0,0q�6B   $	��Top=�6V   $	��110��6n   $��25(�6z   $��53��6�   50      � 53   
   -   5        $��
finishGrid��53      $y�	Collapsed=�6!   .+�54      �� $��0,160,0,117q�6   .+�55      �� -   5        $��resultLabel��55      $(��"Jocul s-a incheiat. Ai ghicit: 0/5��6+   $	��358��6X   $��25(�6d   $y�Visible=�6r   $��Center=�56      �� 58      -   5        $��
restartBtn��58      $��50��6+   $	��100��67   $��Restart��6C   $��20(�6U   $��20q�6c   59      5:      5;      5<      5=      