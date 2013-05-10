using System.Diagnostics;
using EnsureThat.Resources;

namespace EnsureThat
{
    public static class EnsureIntExtensions
    {
        [DebuggerStepThrough]
        public static Param<int> IsLt(this Param<int> param, int limit)
        {
            if (param.Value >= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<int> IsLte(this Param<int> param, int limit)
        {
            if (!(param.Value <= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotLte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<int> IsGt(this Param<int> param, int limit)
        {
            if (param.Value <= limit)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGt.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<int> IsGte(this Param<int> param, int limit)
        {
            if (!(param.Value >= limit))
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotGte.Inject(param.Value, limit));

            return param;
        }

        [DebuggerStepThrough]
        public static Param<int> IsInRange(this Param<int> param, int min, int max)
        {
            if (param.Value < min)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToLow.Inject(param.Value, min));

            if (param.Value > max)
                throw ExceptionFactory.CreateForParamValidation(param, ExceptionMessages.EnsureExtensions_IsNotInRange_ToHigh.Inject(param.Value, max));

            return param;
        }
    }
}