using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GridFightForgeGoodsInfo : IMessage<GridFightForgeGoodsInfo>, IMessage, IEquatable<GridFightForgeGoodsInfo>, IDeepCloneable<GridFightForgeGoodsInfo>, IBufferMessage
{
	public enum CKMEAIDKOIAOneofCase
	{
		None = 0,
		RoleGoodsInfo = 3,
		EquipmentGoodsInfo = 9
	}

	private static readonly MessageParser<GridFightForgeGoodsInfo> _parser = new MessageParser<GridFightForgeGoodsInfo>(() => new GridFightForgeGoodsInfo());

	private UnknownFieldSet _unknownFields;

	public const int RoleGoodsInfoFieldNumber = 3;

	public const int EquipmentGoodsInfoFieldNumber = 9;

	private object cKMEAIDKOIA_;

	private CKMEAIDKOIAOneofCase cKMEAIDKOIACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GridFightForgeGoodsInfo> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GridFightForgeGoodsInfoReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeRoleInfo RoleGoodsInfo
	{
		get
		{
			if (cKMEAIDKOIACase_ != CKMEAIDKOIAOneofCase.RoleGoodsInfo)
			{
				return null;
			}
			return (GridFightForgeRoleInfo)cKMEAIDKOIA_;
		}
		set
		{
			cKMEAIDKOIA_ = value;
			cKMEAIDKOIACase_ = ((value != null) ? CKMEAIDKOIAOneofCase.RoleGoodsInfo : CKMEAIDKOIAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeEquipmentInfo EquipmentGoodsInfo
	{
		get
		{
			if (cKMEAIDKOIACase_ != CKMEAIDKOIAOneofCase.EquipmentGoodsInfo)
			{
				return null;
			}
			return (GridFightForgeEquipmentInfo)cKMEAIDKOIA_;
		}
		set
		{
			cKMEAIDKOIA_ = value;
			cKMEAIDKOIACase_ = ((value != null) ? CKMEAIDKOIAOneofCase.EquipmentGoodsInfo : CKMEAIDKOIAOneofCase.None);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKMEAIDKOIAOneofCase CKMEAIDKOIACase => cKMEAIDKOIACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfo()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfo(GridFightForgeGoodsInfo other)
		: this()
	{
		switch (other.CKMEAIDKOIACase)
		{
		case CKMEAIDKOIAOneofCase.RoleGoodsInfo:
			RoleGoodsInfo = other.RoleGoodsInfo.Clone();
			break;
		case CKMEAIDKOIAOneofCase.EquipmentGoodsInfo:
			EquipmentGoodsInfo = other.EquipmentGoodsInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GridFightForgeGoodsInfo Clone()
	{
		return new GridFightForgeGoodsInfo(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearCKMEAIDKOIA()
	{
		cKMEAIDKOIACase_ = CKMEAIDKOIAOneofCase.None;
		cKMEAIDKOIA_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GridFightForgeGoodsInfo);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GridFightForgeGoodsInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(RoleGoodsInfo, other.RoleGoodsInfo))
		{
			return false;
		}
		if (!object.Equals(EquipmentGoodsInfo, other.EquipmentGoodsInfo))
		{
			return false;
		}
		if (CKMEAIDKOIACase != other.CKMEAIDKOIACase)
		{
			return false;
		}
		return object.Equals(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		int num = 1;
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			num ^= RoleGoodsInfo.GetHashCode();
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.EquipmentGoodsInfo)
		{
			num ^= EquipmentGoodsInfo.GetHashCode();
		}
		num ^= (int)cKMEAIDKOIACase_;
		if (_unknownFields != null)
		{
			num ^= _unknownFields.GetHashCode();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return JsonFormatter.ToDiagnosticString(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
		output.WriteRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalWriteTo(ref WriteContext output)
	{
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			output.WriteRawTag(26);
			output.WriteMessage(RoleGoodsInfo);
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.EquipmentGoodsInfo)
		{
			output.WriteRawTag(74);
			output.WriteMessage(EquipmentGoodsInfo);
		}
		if (_unknownFields != null)
		{
			_unknownFields.WriteTo(ref output);
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		int num = 0;
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleGoodsInfo);
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.EquipmentGoodsInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(EquipmentGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GridFightForgeGoodsInfo other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.CKMEAIDKOIACase)
		{
		case CKMEAIDKOIAOneofCase.RoleGoodsInfo:
			if (RoleGoodsInfo == null)
			{
				RoleGoodsInfo = new GridFightForgeRoleInfo();
			}
			RoleGoodsInfo.MergeFrom(other.RoleGoodsInfo);
			break;
		case CKMEAIDKOIAOneofCase.EquipmentGoodsInfo:
			if (EquipmentGoodsInfo == null)
			{
				EquipmentGoodsInfo = new GridFightForgeEquipmentInfo();
			}
			EquipmentGoodsInfo.MergeFrom(other.EquipmentGoodsInfo);
			break;
		}
		_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
		input.ReadRawMessage(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	void IBufferMessage.InternalMergeFrom(ref ParseContext input)
	{
		uint num;
		while ((num = input.ReadTag()) != 0 && (num & 7) != 4)
		{
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 26u:
			{
				GridFightForgeRoleInfo gridFightForgeRoleInfo = new GridFightForgeRoleInfo();
				if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
				{
					gridFightForgeRoleInfo.MergeFrom(RoleGoodsInfo);
				}
				input.ReadMessage(gridFightForgeRoleInfo);
				RoleGoodsInfo = gridFightForgeRoleInfo;
				break;
			}
			case 74u:
			{
				GridFightForgeEquipmentInfo gridFightForgeEquipmentInfo = new GridFightForgeEquipmentInfo();
				if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.EquipmentGoodsInfo)
				{
					gridFightForgeEquipmentInfo.MergeFrom(EquipmentGoodsInfo);
				}
				input.ReadMessage(gridFightForgeEquipmentInfo);
				EquipmentGoodsInfo = gridFightForgeEquipmentInfo;
				break;
			}
			}
		}
	}
}
