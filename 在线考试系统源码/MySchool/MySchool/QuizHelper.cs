using System;
using System.Collections.Generic;
using System.Text;

namespace MySchool
{
    class QuizHelper
    {
        public static int totalSeconds = 1200; // ������ʱ��20����
        public static int remainSeconds;       // ʣ���ʱ��

        public static int[] allQuestionIds;    // ���������Id����
        public static bool[] selectedStates;   // ��¼��Ӧ�����������Ƿ��Ѿ����������

        public static int questionNum = 20;                        // ��Ŀ����
        public static int[] selectedQuestionIds = new int[20];     // ѡ��������Id����        
        public static string[] correctAnswers = new string[20];    // ��׼������
        public static string[] studentAnswers = new string[20];    // ѧԱ�Ĵ�   
        
    }
}
