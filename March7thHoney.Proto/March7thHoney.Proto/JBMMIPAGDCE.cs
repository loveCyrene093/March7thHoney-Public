using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class JBMMIPAGDCE : IMessage<JBMMIPAGDCE>, IMessage, IEquatable<JBMMIPAGDCE>, IDeepCloneable<JBMMIPAGDCE>, IBufferMessage
{
	private static readonly MessageParser<JBMMIPAGDCE> _parser = new MessageParser<JBMMIPAGDCE>(() => new JBMMIPAGDCE());

	private UnknownFieldSet _unknownFields;

	public const int GBCPGOAFEBCFieldNumber = 7;

	private uint gBCPGOAFEBC_;

	public const int OBHNHKKDGHCFieldNumber = 9;

	private EFEGKDHEMFN oBHNHKKDGHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<JBMMIPAGDCE> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => JBMMIPAGDCEReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GBCPGOAFEBC
	{
		get
		{
			return gBCPGOAFEBC_;
		}
		set
		{
			gBCPGOAFEBC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EFEGKDHEMFN OBHNHKKDGHC
	{
		get
		{
			return oBHNHKKDGHC_;
		}
		set
		{
			oBHNHKKDGHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBMMIPAGDCE()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBMMIPAGDCE(JBMMIPAGDCE other)
		: this()
	{
		gBCPGOAFEBC_ = other.gBCPGOAFEBC_;
		oBHNHKKDGHC_ = ((other.oBHNHKKDGHC_ != null) ? other.oBHNHKKDGHC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JBMMIPAGDCE Clone()
	{
		return new JBMMIPAGDCE(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as JBMMIPAGDCE);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JBMMIPAGDCE other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GBCPGOAFEBC != other.GBCPGOAFEBC)
		{
			return false;
		}
		if (!object.Equals(OBHNHKKDGHC, other.OBHNHKKDGHC))
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
		if (GBCPGOAFEBC != 0)
		{
			num ^= GBCPGOAFEBC.GetHashCode();
		}
		if (oBHNHKKDGHC_ != null)
		{
			num ^= OBHNHKKDGHC.GetHashCode();
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
		if (GBCPGOAFEBC != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(GBCPGOAFEBC);
		}
		if (oBHNHKKDGHC_ != null)
		{
			output.WriteRawTag(74);
			output.WriteMessage(OBHNHKKDGHC);
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
		if (GBCPGOAFEBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBCPGOAFEBC);
		}
		if (oBHNHKKDGHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OBHNHKKDGHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JBMMIPAGDCE other)
	{
		if (other == null)
		{
			return;
		}
		if (other.GBCPGOAFEBC != 0)
		{
			GBCPGOAFEBC = other.GBCPGOAFEBC;
		}
		if (other.oBHNHKKDGHC_ != null)
		{
			if (oBHNHKKDGHC_ == null)
			{
				OBHNHKKDGHC = new EFEGKDHEMFN();
			}
			OBHNHKKDGHC.MergeFrom(other.OBHNHKKDGHC);
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
			case 56u:
				GBCPGOAFEBC = input.ReadUInt32();
				break;
			case 74u:
				if (oBHNHKKDGHC_ == null)
				{
					OBHNHKKDGHC = new EFEGKDHEMFN();
				}
				input.ReadMessage(OBHNHKKDGHC);
				break;
			}
		}
	}
}
