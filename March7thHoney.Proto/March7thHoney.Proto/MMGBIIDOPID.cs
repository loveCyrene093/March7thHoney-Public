using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MMGBIIDOPID : IMessage<MMGBIIDOPID>, IMessage, IEquatable<MMGBIIDOPID>, IDeepCloneable<MMGBIIDOPID>, IBufferMessage
{
	private static readonly MessageParser<MMGBIIDOPID> _parser = new MessageParser<MMGBIIDOPID>(() => new MMGBIIDOPID());

	private UnknownFieldSet _unknownFields;

	public const int CLAFNDLGDAOFieldNumber = 7;

	private uint cLAFNDLGDAO_;

	public const int ItemStackCountFieldNumber = 12;

	private uint itemStackCount_;

	public const int MJDMLOIHLPAFieldNumber = 15;

	private DDKHEFEBFAJ mJDMLOIHLPA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MMGBIIDOPID> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MMGBIIDOPIDReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CLAFNDLGDAO
	{
		get
		{
			return cLAFNDLGDAO_;
		}
		set
		{
			cLAFNDLGDAO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ItemStackCount
	{
		get
		{
			return itemStackCount_;
		}
		set
		{
			itemStackCount_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DDKHEFEBFAJ MJDMLOIHLPA
	{
		get
		{
			return mJDMLOIHLPA_;
		}
		set
		{
			mJDMLOIHLPA_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGBIIDOPID()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGBIIDOPID(MMGBIIDOPID other)
		: this()
	{
		cLAFNDLGDAO_ = other.cLAFNDLGDAO_;
		itemStackCount_ = other.itemStackCount_;
		mJDMLOIHLPA_ = other.mJDMLOIHLPA_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MMGBIIDOPID Clone()
	{
		return new MMGBIIDOPID(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MMGBIIDOPID);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MMGBIIDOPID other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CLAFNDLGDAO != other.CLAFNDLGDAO)
		{
			return false;
		}
		if (ItemStackCount != other.ItemStackCount)
		{
			return false;
		}
		if (MJDMLOIHLPA != other.MJDMLOIHLPA)
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
		if (CLAFNDLGDAO != 0)
		{
			num ^= CLAFNDLGDAO.GetHashCode();
		}
		if (ItemStackCount != 0)
		{
			num ^= ItemStackCount.GetHashCode();
		}
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			num ^= MJDMLOIHLPA.GetHashCode();
		}
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
		if (CLAFNDLGDAO != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(CLAFNDLGDAO);
		}
		if (ItemStackCount != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ItemStackCount);
		}
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			output.WriteRawTag(120);
			output.WriteEnum((int)MJDMLOIHLPA);
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
		if (CLAFNDLGDAO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CLAFNDLGDAO);
		}
		if (ItemStackCount != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ItemStackCount);
		}
		if (MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)MJDMLOIHLPA);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MMGBIIDOPID other)
	{
		if (other != null)
		{
			if (other.CLAFNDLGDAO != 0)
			{
				CLAFNDLGDAO = other.CLAFNDLGDAO;
			}
			if (other.ItemStackCount != 0)
			{
				ItemStackCount = other.ItemStackCount;
			}
			if (other.MJDMLOIHLPA != DDKHEFEBFAJ.Pcpdhelpkem)
			{
				MJDMLOIHLPA = other.MJDMLOIHLPA;
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
			case 56u:
				CLAFNDLGDAO = input.ReadUInt32();
				break;
			case 96u:
				ItemStackCount = input.ReadUInt32();
				break;
			case 120u:
				MJDMLOIHLPA = (DDKHEFEBFAJ)input.ReadEnum();
				break;
			}
		}
	}
}
