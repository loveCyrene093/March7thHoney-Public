using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IFDFHPAMHCL : IMessage<IFDFHPAMHCL>, IMessage, IEquatable<IFDFHPAMHCL>, IDeepCloneable<IFDFHPAMHCL>, IBufferMessage
{
	private static readonly MessageParser<IFDFHPAMHCL> _parser = new MessageParser<IFDFHPAMHCL>(() => new IFDFHPAMHCL());

	private UnknownFieldSet _unknownFields;

	public const int KKMBLCJHAHKFieldNumber = 1;

	private uint kKMBLCJHAHK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IFDFHPAMHCL> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IFDFHPAMHCLReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KKMBLCJHAHK
	{
		get
		{
			return kKMBLCJHAHK_;
		}
		set
		{
			kKMBLCJHAHK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDFHPAMHCL()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDFHPAMHCL(IFDFHPAMHCL other)
		: this()
	{
		kKMBLCJHAHK_ = other.kKMBLCJHAHK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IFDFHPAMHCL Clone()
	{
		return new IFDFHPAMHCL(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IFDFHPAMHCL);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IFDFHPAMHCL other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (KKMBLCJHAHK != other.KKMBLCJHAHK)
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
		if (KKMBLCJHAHK != 0)
		{
			num ^= KKMBLCJHAHK.GetHashCode();
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
		if (KKMBLCJHAHK != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(KKMBLCJHAHK);
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
		if (KKMBLCJHAHK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KKMBLCJHAHK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IFDFHPAMHCL other)
	{
		if (other != null)
		{
			if (other.KKMBLCJHAHK != 0)
			{
				KKMBLCJHAHK = other.KKMBLCJHAHK;
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
			if (num != 8)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				KKMBLCJHAHK = input.ReadUInt32();
			}
		}
	}
}
