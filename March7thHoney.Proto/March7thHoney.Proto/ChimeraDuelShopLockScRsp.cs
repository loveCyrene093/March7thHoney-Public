using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChimeraDuelShopLockScRsp : IMessage<ChimeraDuelShopLockScRsp>, IMessage, IEquatable<ChimeraDuelShopLockScRsp>, IDeepCloneable<ChimeraDuelShopLockScRsp>, IBufferMessage
{
	public enum BPIHFAJCLOCOneofCase
	{
		None = 0,
		DEAKOOEBLJL = 3,
		HCNKAJNKGFH = 15
	}

	private static readonly MessageParser<ChimeraDuelShopLockScRsp> _parser = new MessageParser<ChimeraDuelShopLockScRsp>(() => new ChimeraDuelShopLockScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 2;

	private uint retcode_;

	public const int IsLockedFieldNumber = 14;

	private bool isLocked_;

	public const int DEAKOOEBLJLFieldNumber = 3;

	public const int HCNKAJNKGFHFieldNumber = 15;

	private object bPIHFAJCLOC_;

	private BPIHFAJCLOCOneofCase bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChimeraDuelShopLockScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChimeraDuelShopLockScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
		}
	}

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
	public BPIHFAJCLOCOneofCase BPIHFAJCLOCCase => bPIHFAJCLOCCase_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockScRsp(ChimeraDuelShopLockScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		isLocked_ = other.isLocked_;
		switch (other.BPIHFAJCLOCCase)
		{
		case BPIHFAJCLOCOneofCase.DEAKOOEBLJL:
			DEAKOOEBLJL = other.DEAKOOEBLJL;
			break;
		case BPIHFAJCLOCOneofCase.HCNKAJNKGFH:
			HCNKAJNKGFH = other.HCNKAJNKGFH;
			break;
		}
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChimeraDuelShopLockScRsp Clone()
	{
		return new ChimeraDuelShopLockScRsp(this);
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
	public void ClearHCNKAJNKGFH()
	{
		if (HasHCNKAJNKGFH)
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
		return Equals(other as ChimeraDuelShopLockScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChimeraDuelShopLockScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (IsLocked != other.IsLocked)
		{
			return false;
		}
		if (DEAKOOEBLJL != other.DEAKOOEBLJL)
		{
			return false;
		}
		if (HCNKAJNKGFH != other.HCNKAJNKGFH)
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (IsLocked)
		{
			num ^= IsLocked.GetHashCode();
		}
		if (HasDEAKOOEBLJL)
		{
			num ^= DEAKOOEBLJL.GetHashCode();
		}
		if (HasHCNKAJNKGFH)
		{
			num ^= HCNKAJNKGFH.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(Retcode);
		}
		if (HasDEAKOOEBLJL)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DEAKOOEBLJL);
		}
		if (IsLocked)
		{
			output.WriteRawTag(112);
			output.WriteBool(IsLocked);
		}
		if (HasHCNKAJNKGFH)
		{
			output.WriteRawTag(120);
			output.WriteUInt32(HCNKAJNKGFH);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (IsLocked)
		{
			num += 2;
		}
		if (HasDEAKOOEBLJL)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DEAKOOEBLJL);
		}
		if (HasHCNKAJNKGFH)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HCNKAJNKGFH);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ChimeraDuelShopLockScRsp other)
	{
		if (other != null)
		{
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.IsLocked)
			{
				IsLocked = other.IsLocked;
			}
			switch (other.BPIHFAJCLOCCase)
			{
			case BPIHFAJCLOCOneofCase.DEAKOOEBLJL:
				DEAKOOEBLJL = other.DEAKOOEBLJL;
				break;
			case BPIHFAJCLOCOneofCase.HCNKAJNKGFH:
				HCNKAJNKGFH = other.HCNKAJNKGFH;
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
			case 16u:
				Retcode = input.ReadUInt32();
				break;
			case 24u:
				DEAKOOEBLJL = input.ReadUInt32();
				break;
			case 112u:
				IsLocked = input.ReadBool();
				break;
			case 120u:
				HCNKAJNKGFH = input.ReadUInt32();
				break;
			}
		}
	}
}
