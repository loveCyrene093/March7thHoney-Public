using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GGJFDIHCFIH : IMessage<GGJFDIHCFIH>, IMessage, IEquatable<GGJFDIHCFIH>, IDeepCloneable<GGJFDIHCFIH>, IBufferMessage
{
	private static readonly MessageParser<GGJFDIHCFIH> _parser = new MessageParser<GGJFDIHCFIH>(() => new GGJFDIHCFIH());

	private UnknownFieldSet _unknownFields;

	public const int OBHNHKKDGHCFieldNumber = 6;

	private EFEGKDHEMFN oBHNHKKDGHC_;

	public const int GBCPGOAFEBCFieldNumber = 11;

	private uint gBCPGOAFEBC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GGJFDIHCFIH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GGJFDIHCFIHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public GGJFDIHCFIH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGJFDIHCFIH(GGJFDIHCFIH other)
		: this()
	{
		oBHNHKKDGHC_ = ((other.oBHNHKKDGHC_ != null) ? other.oBHNHKKDGHC_.Clone() : null);
		gBCPGOAFEBC_ = other.gBCPGOAFEBC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GGJFDIHCFIH Clone()
	{
		return new GGJFDIHCFIH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GGJFDIHCFIH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GGJFDIHCFIH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OBHNHKKDGHC, other.OBHNHKKDGHC))
		{
			return false;
		}
		if (GBCPGOAFEBC != other.GBCPGOAFEBC)
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
		if (oBHNHKKDGHC_ != null)
		{
			num ^= OBHNHKKDGHC.GetHashCode();
		}
		if (GBCPGOAFEBC != 0)
		{
			num ^= GBCPGOAFEBC.GetHashCode();
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
		if (oBHNHKKDGHC_ != null)
		{
			output.WriteRawTag(50);
			output.WriteMessage(OBHNHKKDGHC);
		}
		if (GBCPGOAFEBC != 0)
		{
			output.WriteRawTag(88);
			output.WriteUInt32(GBCPGOAFEBC);
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
		if (oBHNHKKDGHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OBHNHKKDGHC);
		}
		if (GBCPGOAFEBC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GBCPGOAFEBC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GGJFDIHCFIH other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oBHNHKKDGHC_ != null)
		{
			if (oBHNHKKDGHC_ == null)
			{
				OBHNHKKDGHC = new EFEGKDHEMFN();
			}
			OBHNHKKDGHC.MergeFrom(other.OBHNHKKDGHC);
		}
		if (other.GBCPGOAFEBC != 0)
		{
			GBCPGOAFEBC = other.GBCPGOAFEBC;
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
			case 50u:
				if (oBHNHKKDGHC_ == null)
				{
					OBHNHKKDGHC = new EFEGKDHEMFN();
				}
				input.ReadMessage(OBHNHKKDGHC);
				break;
			case 88u:
				GBCPGOAFEBC = input.ReadUInt32();
				break;
			}
		}
	}
}
