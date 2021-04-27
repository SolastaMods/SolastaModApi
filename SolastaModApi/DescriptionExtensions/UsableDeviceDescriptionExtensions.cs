using SolastaModApi.Infrastructure;
using UnityEngine.AddressableAssets;
using static RuleDefinitions;

namespace SolastaModApi
{
    public static class UsableDeviceDescriptionExtensions
    {
        public static T SetChargesCapital<T>(this T entity, EquipmentDefinitions.ItemChargesCapital value)
            where T : UsableDeviceDescription
        {
            entity.SetField("chargesCapital", value);
            return entity;
        }

        public static T SetChargesCapitalBonus<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("chargesCapitalBonus", value);
            return entity;
        }

        public static T SetChargesCapitalDie<T>(this T entity, DieType value)
            where T : UsableDeviceDescription
        {
            entity.SetField("chargesCapitalDie", value);
            return entity;
        }

        public static T SetChargesCapitalNumber<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("chargesCapitalNumber", value);
            return entity;
        }

        public static T SetMagicAttackBonus<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("magicAttackBonus", value);
            return entity;
        }

        public static T SetOnUseParticle<T>(this T entity, AssetReference value)
            where T : UsableDeviceDescription
        {
            entity.SetField("onUseParticle", value);
            return entity;
        }

        public static T SetOutOfChargesConsequence<T>(this T entity, EquipmentDefinitions.ItemOutOfCharges value)
            where T : UsableDeviceDescription
        {
            entity.SetField("outOfChargesConsequence", value);
            return entity;
        }

        public static T SetRechargeBonus<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("rechargeBonus", value);
            return entity;
        }

        public static T SetRechargeDie<T>(this T entity, DieType value)
            where T : UsableDeviceDescription
        {
            entity.SetField("rechargeDie", value);
            return entity;
        }

        public static T SetRechargeNumber<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("rechargeNumber", value);
            return entity;
        }

        public static T SetRechargeRate<T>(this T entity, RechargeRate value)
            where T : UsableDeviceDescription
        {
            entity.SetField("rechargeRate", value);
            return entity;
        }

        public static T SetSaveDC<T>(this T entity, int value)
            where T : UsableDeviceDescription
        {
            entity.SetField("saveDC", value);
            return entity;
        }

        public static T SetUsage<T>(this T entity, EquipmentDefinitions.ItemUsage value)
            where T : UsableDeviceDescription
        {
            entity.SetField("usage", value);
            return entity;
        }
    }
}