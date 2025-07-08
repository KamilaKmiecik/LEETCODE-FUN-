public class Solution {

    public IList<IList<int>> Generate(int numRows) {
          var list = new List<IList<int>>();

  if (numRows == 0)
      return list; 

  list.Add(new List<int>() { 1});

  if (numRows == 1)
      return list;

  for (int i = 1; i < numRows; i++)
  {
      List<int> previous = (List<int>)list[i - 1];

      //left corner always 1
      List<int> added = new List<int> { 1 };

      for (int j = 1; j < previous.Count; j++)
      {
          //grabbing two from the top
          added.Add(previous[j - 1] + previous[j]);
      }

      //right corner always 1
      added.Add(1);
      list.Add(added); ;
  }

  return list;
    }
}