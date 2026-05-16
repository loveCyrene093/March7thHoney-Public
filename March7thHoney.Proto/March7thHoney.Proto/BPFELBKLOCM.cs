using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BPFELBKLOCM : IMessage<BPFELBKLOCM>, IMessage, IEquatable<BPFELBKLOCM>, IDeepCloneable<BPFELBKLOCM>, IBufferMessage
{
	public enum CKMEAIDKOIAOneofCase
	{
		None = 0,
		Gold = 4,
		RoleGoodsInfo = 9
	}

	private static readonly MessageParser<BPFELBKLOCM> _parser = new MessageParser<BPFELBKLOCM>(() => new BPFELBKLOCM());

	private UnknownFieldSet _unknownFields;

	public const int GoldFieldNumber = 4;

	public const int RoleGoodsInfoFieldNumber = 9;

	private object cKMEAIDKOIA_;

	private CKMEAIDKOIAOneofCase cKMEAIDKOIACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BPFELBKLOCM> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BPFELBKLOCMReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Gold
	{
		get
		{
			if (!HasGold)
			{
				return 0u;
			}
			return (uint)cKMEAIDKOIA_;
		}
		set
		{
			cKMEAIDKOIA_ = value;
			cKMEAIDKOIACase_ = CKMEAIDKOIAOneofCase.Gold;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasGold => cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.Gold;

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
	public CKMEAIDKOIAOneofCase CKMEAIDKOIACase => cKMEAIDKOIACase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPFELBKLOCM()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPFELBKLOCM(BPFELBKLOCM other)
		: this()
	{
		switch (other.CKMEAIDKOIACase)
		{
		case CKMEAIDKOIAOneofCase.Gold:
			Gold = other.Gold;
			break;
		case CKMEAIDKOIAOneofCase.RoleGoodsInfo:
			RoleGoodsInfo = other.RoleGoodsInfo.Clone();
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPFELBKLOCM Clone()
	{
		return new BPFELBKLOCM(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearGold()
	{
		if (HasGold)
		{
			ClearCKMEAIDKOIA();
		}
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
		return Equals(other as BPFELBKLOCM);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BPFELBKLOCM other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Gold != other.Gold)
		{
			return false;
		}
		if (!object.Equals(RoleGoodsInfo, other.RoleGoodsInfo))
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
		if (HasGold)
		{
			num ^= Gold.GetHashCode();
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			num ^= RoleGoodsInfo.GetHashCode();
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
		if (HasGold)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Gold);
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			output.WriteRawTag(74);
			output.WriteMessage(RoleGoodsInfo);
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
		if (HasGold)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Gold);
		}
		if (cKMEAIDKOIACase_ == CKMEAIDKOIAOneofCase.RoleGoodsInfo)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(RoleGoodsInfo);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BPFELBKLOCM other)
	{
		if (other == null)
		{
			return;
		}
		switch (other.CKMEAIDKOIACase)
		{
		case CKMEAIDKOIAOneofCase.Gold:
			Gold = other.Gold;
			break;
		case CKMEAIDKOIAOneofCase.RoleGoodsInfo:
			if (RoleGoodsInfo == null)
			{
				RoleGoodsInfo = new GridFightForgeRoleInfo();
			}
			RoleGoodsInfo.MergeFrom(other.RoleGoodsInfo);
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
			case 32u:
				Gold = input.ReadUInt32();
				break;
			case 74u:
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
			}
		}
	}
}
