using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CIFMOICFJDF : IMessage<CIFMOICFJDF>, IMessage, IEquatable<CIFMOICFJDF>, IDeepCloneable<CIFMOICFJDF>, IBufferMessage
{
	private static readonly MessageParser<CIFMOICFJDF> _parser = new MessageParser<CIFMOICFJDF>(() => new CIFMOICFJDF());

	private UnknownFieldSet _unknownFields;

	public const int PKBLOMEIFMDFieldNumber = 6;

	private uint pKBLOMEIFMD_;

	public const int ICINHMIKJLHFieldNumber = 7;

	private uint iCINHMIKJLH_;

	public const int PMBAPKJMBNMFieldNumber = 9;

	private uint pMBAPKJMBNM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CIFMOICFJDF> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CIFMOICFJDFReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PKBLOMEIFMD
	{
		get
		{
			return pKBLOMEIFMD_;
		}
		set
		{
			pKBLOMEIFMD_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ICINHMIKJLH
	{
		get
		{
			return iCINHMIKJLH_;
		}
		set
		{
			iCINHMIKJLH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PMBAPKJMBNM
	{
		get
		{
			return pMBAPKJMBNM_;
		}
		set
		{
			pMBAPKJMBNM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMOICFJDF()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMOICFJDF(CIFMOICFJDF other)
		: this()
	{
		pKBLOMEIFMD_ = other.pKBLOMEIFMD_;
		iCINHMIKJLH_ = other.iCINHMIKJLH_;
		pMBAPKJMBNM_ = other.pMBAPKJMBNM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CIFMOICFJDF Clone()
	{
		return new CIFMOICFJDF(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CIFMOICFJDF);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CIFMOICFJDF other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PKBLOMEIFMD != other.PKBLOMEIFMD)
		{
			return false;
		}
		if (ICINHMIKJLH != other.ICINHMIKJLH)
		{
			return false;
		}
		if (PMBAPKJMBNM != other.PMBAPKJMBNM)
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
		if (PKBLOMEIFMD != 0)
		{
			num ^= PKBLOMEIFMD.GetHashCode();
		}
		if (ICINHMIKJLH != 0)
		{
			num ^= ICINHMIKJLH.GetHashCode();
		}
		if (PMBAPKJMBNM != 0)
		{
			num ^= PMBAPKJMBNM.GetHashCode();
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
		if (PKBLOMEIFMD != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(PKBLOMEIFMD);
		}
		if (ICINHMIKJLH != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(ICINHMIKJLH);
		}
		if (PMBAPKJMBNM != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(PMBAPKJMBNM);
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
		if (PKBLOMEIFMD != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PKBLOMEIFMD);
		}
		if (ICINHMIKJLH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ICINHMIKJLH);
		}
		if (PMBAPKJMBNM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PMBAPKJMBNM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CIFMOICFJDF other)
	{
		if (other != null)
		{
			if (other.PKBLOMEIFMD != 0)
			{
				PKBLOMEIFMD = other.PKBLOMEIFMD;
			}
			if (other.ICINHMIKJLH != 0)
			{
				ICINHMIKJLH = other.ICINHMIKJLH;
			}
			if (other.PMBAPKJMBNM != 0)
			{
				PMBAPKJMBNM = other.PMBAPKJMBNM;
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
			case 48u:
				PKBLOMEIFMD = input.ReadUInt32();
				break;
			case 56u:
				ICINHMIKJLH = input.ReadUInt32();
				break;
			case 72u:
				PMBAPKJMBNM = input.ReadUInt32();
				break;
			}
		}
	}
}
