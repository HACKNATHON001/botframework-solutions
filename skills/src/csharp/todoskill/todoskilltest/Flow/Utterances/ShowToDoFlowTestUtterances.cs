﻿using Luis;
using ToDoSkillTest.Flow.Fakes;

namespace ToDoSkillTest.Flow.Utterances
{
    public class ShowToDoFlowTestUtterances : BaseTestUtterances
    {
        public ShowToDoFlowTestUtterances()
        {
            var listType = new string[] { MockData.ToDo };
            this.Add(ShowToDoList, GetBaseShowTasksIntent(ShowToDoList, listType: listType));

            listType = new string[] { MockData.Grocery };
            this.Add(ShowGroceryList, GetBaseShowTasksIntent(ShowGroceryList, listType: listType));

            listType = new string[] { MockData.Shopping };
            this.Add(ShowShoppingList, GetBaseShowTasksIntent(ShowShoppingList, listType: listType));

            listType = new string[] { MockData.CustomizedListType };
            this.Add(ShowCustomizedListTypeList, GetBaseShowTasksIntent(ShowCustomizedListTypeList, listType: listType));
        }

        public static string ShowToDoList { get; } = "Show my to do list";

        public static string ShowGroceryList { get; } = "Show my grocery list";

        public static string ShowShoppingList { get; } = "Show my shopping list";

        public static string ShowCustomizedListTypeList { get; } = "Show my homework list";

        private todoLuis GetBaseShowTasksIntent(
            string userInput,
            todoLuis.Intent intents = todoLuis.Intent.ShowToDo,
            string[] listType = null)
        {
            return GetToDoIntent(
                userInput,
                intents,
                listType: listType);
        }
    }
}
