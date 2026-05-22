using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KMDBMLAICLB : IMessage<KMDBMLAICLB>, IMessage, IEquatable<KMDBMLAICLB>, IDeepCloneable<KMDBMLAICLB>, IBufferMessage
{
	private static readonly MessageParser<KMDBMLAICLB> _parser = new MessageParser<KMDBMLAICLB>(() => new KMDBMLAICLB());

	private UnknownFieldSet _unknownFields;

	public const int BPAOPCLBEKGFieldNumber = 6;

	private uint bPAOPCLBEKG_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KMDBMLAICLB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KMDBMLAICLBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint BPAOPCLBEKG
	{
		get
		{
			return bPAOPCLBEKG_;
		}
		set
		{
			bPAOPCLBEKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMDBMLAICLB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMDBMLAICLB(KMDBMLAICLB other)
		: this()
	{
		bPAOPCLBEKG_ = other.bPAOPCLBEKG_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KMDBMLAICLB Clone()
	{
		return new KMDBMLAICLB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KMDBMLAICLB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KMDBMLAICLB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (BPAOPCLBEKG != other.BPAOPCLBEKG)
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
		if (BPAOPCLBEKG != 0)
		{
			num ^= BPAOPCLBEKG.GetHashCode();
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
		if (BPAOPCLBEKG != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(BPAOPCLBEKG);
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
		if (BPAOPCLBEKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(BPAOPCLBEKG);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KMDBMLAICLB other)
	{
		if (other != null)
		{
			if (other.BPAOPCLBEKG != 0)
			{
				BPAOPCLBEKG = other.BPAOPCLBEKG;
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
			if (num != 48)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				BPAOPCLBEKG = input.ReadUInt32();
			}
		}
	}
}
