using System;

ScoreTracker st = new ScoreTracker("수학");
st.SetScore(85);
st.SetScore(200);
st.AddBonus(10);
st.AddBonus(20);
st.AddBonus(120);
st.ShowScore();
class ScoreTracker
{
    const int MaxScore = 100;
    const int MinScore = 0;
    private readonly string subject;
    private int score = 0;
    private int bonus = 0;

    public ScoreTracker(string subject)
    {
        this.subject = subject; 
    }

    public void SetScore(int score)
    {
        if(score < MinScore || score > MaxScore)
        {
            Console.WriteLine($"점수는 {MinScore}~{MaxScore} 사이여야 합니다.\n");
            return;
        }
        this.score = score;
        Console.WriteLine($"점수를 {score}점으로 설정했습니다.\n");
    }
    public void AddBonus(int bonus)
    {
        if (bonus < MinScore || bonus > MaxScore)
        {
            Console.WriteLine($"점수는 {MinScore}~{MaxScore} 사이여야 합니다.\n");
            return;
        }
        if(score + bonus > MaxScore)
        {
            score = MaxScore;
            this.bonus++;
            Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점 (최대 점수 도달)");
            return;
        }
        this.score += bonus;
        this.bonus++;
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점");
    }
    public void ShowScore()
    {
        Console.WriteLine($"=== {subject} ===");
        Console.WriteLine($"점수: {score} / {MaxScore}");
        Console.WriteLine($"보너스 적용 횟수: {bonus}");
        Console.WriteLine();
    }
}