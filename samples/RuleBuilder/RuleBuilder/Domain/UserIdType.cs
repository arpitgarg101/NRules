// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserIdType.cs" company="Microsoft">
//   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//   IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
//   THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR
//   OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
//   ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//   OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NRules.Samples.RuleBuilder.Domain
{
    /// <summary>
    /// The transaction status code.
    /// </summary>
    public enum UserIdType
    {
        /// <summary>
        /// None Value.
        /// </summary>
        None,

        /// <summary>
        /// The Email.
        /// </summary>
        Email,

        /// <summary>
        /// The Phone.
        /// </summary>
        Phone,

        /// <summary>
        /// Loyalty identity.
        /// </summary>
        LoyaltyId,

        /// <summary>
        /// Astra identity.
        /// </summary>
        AstraId,
    }
}