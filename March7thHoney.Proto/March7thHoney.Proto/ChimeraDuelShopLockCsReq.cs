using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelShopLockCsReq : IMessage<ChimeraDuelShopLockCsReq>, IMessage, IEquatable<ChimeraDuelShopLockCsReq>, IDeepCloneable<ChimeraDuelShopLockCsReq>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		HCNKAJNKGFH = 8,
		DEAKOOEBLJL = 13
	}

	private static readonly MessageParser<ChimeraDuelShopLockCsReq> _parser = new MessageParser<ChimeraDuelShopLockCsReq>(() => new ChimeraDuelShopLockCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IsLockedFieldNumber = 15;

	private bool isLocked_;

	public const int HCNKAJNKGFHFieldNumber = 8;

	public const int DEAKOOEBLJLFieldNumber = 13;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelShopLockCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelShopLockCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool IsLocked
	{
		get
		{
			return isLocked_;
		}
		set
		{
			isLocked_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint HCNKAJNKGFH
	{
		get
		{
			if (!HasHCNKAJNKGFH)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.HCNKAJNKGFH;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasHCNKAJNKGFH => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.HCNKAJNKGFH;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DEAKOOEBLJL
	{
		get
		{
			if (!HasDEAKOOEBLJL)
			{
				return 0u;
			}
			return (uint)bPIHFAJCLOC_;
		}
		set
		{
			bPIHFAJCLOC_ = value;
			bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.DEAKOOEBLJL;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasDEAKOOEBLJL => bPIHFAJCLOCCase_ == BPIHFAJCLOCOneofCase.DEAKOOEBLJL;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockCsReq(ChimeraDuelShopLockCsReq other)
		: this()
	{
		isLocked_ = other.isLocked_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.HCNKAJNKGFH:
			HCNKAJNKGFH = other.HCNKAJNKGFH;
			break;
		case BPIHFAJCLOCOneofCase.DEAKOOEBLJL:
			DEAKOOEBLJL = other.DEAKOOEBLJL;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockCsReq Clone()
	{
		return new ChimeraDuelShopLockCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearHCNKAJNKGFH()
	{
		if (HasHCNKAJNKGFH)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearDEAKOOEBLJL()
	{
		if (HasDEAKOOEBLJL)
		{
			ClearBPIHFAJCLOC();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearBPIHFAJCLOC()
	{
		bPIHFAJCLOCCase_ = BPIHFAJCLOCOneofCase.None;
		bPIHFAJCLOC_ = null;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChimeraDuelShopLockCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelShopLockCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (IsLocked != other.IsLocked)
		{
			return false;
		}
		if (HCNKAJNKGFH != other.HCNKAJNKGFH)
		{
			return false;
		}
		if (DEAKOOEBLJL != other.DEAKOOEBLJL)
		{
			return false;
		}
		if (BPIHFAJCLOCCase != other.BPIHFAJCLOCCase)
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
		if (IsLocked)
		{
			num ^= IsLocked.GetHashCode();
		}
		if (HasHCNKAJNKGFH)
		{
			num ^= HCNKAJNKGFH.GetHashCode();
		}
		if (HasDEAKOOEBLJL)
		{
			num ^= DEAKOOEBLJL.GetHashCode();
		}
		num ^= (int)bPIHFAJCLOCCase_;
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
		if (HasHCNKAJNKGFH)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(HCNKAJNKGFH);
		}
		if (HasDEAKOOEBLJL)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(DEAKOOEBLJL);
		}
		if (IsLocked)
		{
			output.WriteRawTag(120);
			output.WriteBool(IsLocked);
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
		if (IsLocked)
		{
			num += 2;
		}
		if (HasHCNKAJNKGFH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCNKAJNKGFH);
		}
		if (HasDEAKOOEBLJL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEAKOOEBLJL);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelShopLockCsReq other)
	{
		if (other != null)
		{
			if (other.IsLocked)
			{
				IsLocked = other.IsLocked;
			}
			switch (other.BPIHFAJCLOCCase)
			{
			case BPIHFAJCLOCOneofCase.HCNKAJNKGFH:
				HCNKAJNKGFH = other.HCNKAJNKGFH;
				break;
			case BPIHFAJCLOCOneofCase.DEAKOOEBLJL:
				DEAKOOEBLJL = other.DEAKOOEBLJL;
				break;
			}
			_unknownFields = UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
		}
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
			case 64u:
				HCNKAJNKGFH = input.ReadUInt32();
				break;
			case 104u:
				DEAKOOEBLJL = input.ReadUInt32();
				break;
			case 120u:
				IsLocked = input.ReadBool();
				break;
			}
		}
	}
}
