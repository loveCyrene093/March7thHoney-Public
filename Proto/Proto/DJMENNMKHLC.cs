using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class DJMENNMKHLC : IMessage<DJMENNMKHLC>, IMessage, IEquatable<DJMENNMKHLC>, IDeepCloneable<DJMENNMKHLC>, IBufferMessage
{
	private static readonly MessageParser<DJMENNMKHLC> _parser = new MessageParser<DJMENNMKHLC>(() => new DJMENNMKHLC());

	private UnknownFieldSet _unknownFields;

	public const int CHKLFKHFLKGFieldNumber = 1;

	private uint cHKLFKHFLKG_;

	public const int ABIEOJHCCKBFieldNumber = 2;

	private uint aBIEOJHCCKB_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<DJMENNMKHLC> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => DJMENNMKHLCReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint CHKLFKHFLKG
	{
		get
		{
			return cHKLFKHFLKG_;
		}
		set
		{
			cHKLFKHFLKG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ABIEOJHCCKB
	{
		get
		{
			return aBIEOJHCCKB_;
		}
		set
		{
			aBIEOJHCCKB_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJMENNMKHLC()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJMENNMKHLC(DJMENNMKHLC other)
		: this()
	{
		cHKLFKHFLKG_ = other.cHKLFKHFLKG_;
		aBIEOJHCCKB_ = other.aBIEOJHCCKB_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public DJMENNMKHLC Clone()
	{
		return new DJMENNMKHLC(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as DJMENNMKHLC);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DJMENNMKHLC other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (CHKLFKHFLKG != other.CHKLFKHFLKG)
		{
			return false;
		}
		if (ABIEOJHCCKB != other.ABIEOJHCCKB)
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
		if (CHKLFKHFLKG != 0)
		{
			num ^= CHKLFKHFLKG.GetHashCode();
		}
		if (ABIEOJHCCKB != 0)
		{
			num ^= ABIEOJHCCKB.GetHashCode();
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
		if (CHKLFKHFLKG != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(CHKLFKHFLKG);
		}
		if (ABIEOJHCCKB != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(ABIEOJHCCKB);
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
		if (CHKLFKHFLKG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(CHKLFKHFLKG);
		}
		if (ABIEOJHCCKB != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ABIEOJHCCKB);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DJMENNMKHLC other)
	{
		if (other != null)
		{
			if (other.CHKLFKHFLKG != 0)
			{
				CHKLFKHFLKG = other.CHKLFKHFLKG;
			}
			if (other.ABIEOJHCCKB != 0)
			{
				ABIEOJHCCKB = other.ABIEOJHCCKB;
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
			case 8u:
				CHKLFKHFLKG = input.ReadUInt32();
				break;
			case 16u:
				ABIEOJHCCKB = input.ReadUInt32();
				break;
			}
		}
	}
}
