using AElf.Sdk.CSharp.State;

namespace AElf.Contracts.ToDoApp
{
    // The state class is access the blockchain state
    public class ToDoAppState : ContractState 
    {
        // A state that holds string value
        public StringState Message { get; set; }
    }
}