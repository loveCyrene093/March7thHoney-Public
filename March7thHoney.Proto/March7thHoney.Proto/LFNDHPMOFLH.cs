using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class LFNDHPMOFLH : IMessage<LFNDHPMOFLH>, IMessage, IEquatable<LFNDHPMOFLH>, IDeepCloneable<LFNDHPMOFLH>, IBufferMessage
{
	private static readonly MessageParser<LFNDHPMOFLH> _parser = new MessageParser<LFNDHPMOFLH>(() => new LFNDHPMOFLH());

	private UnknownFieldSet _unknownFields;

	public const int DHLDKLMPHNGFieldNumber = 10;

	private uint dHLDKLMPHNG_;

	public const int LMIICENMOBIFieldNumber = 12;

	private uint lMIICENMOBI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LFNDHPMOFLH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => LFNDHPMOFLHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHLDKLMPHNG
	{
		get
		{
			return dHLDKLMPHNG_;
		}
		set
		{
			dHLDKLMPHNG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LMIICENMOBI
	{
		get
		{
			return lMIICENMOBI_;
		}
		set
		{
			lMIICENMOBI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFNDHPMOFLH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFNDHPMOFLH(LFNDHPMOFLH other)
		: this()
	{
		dHLDKLMPHNG_ = other.dHLDKLMPHNG_;
		lMIICENMOBI_ = other.lMIICENMOBI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LFNDHPMOFLH Clone()
	{
		return new LFNDHPMOFLH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as LFNDHPMOFLH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LFNDHPMOFLH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DHLDKLMPHNG != other.DHLDKLMPHNG)
		{
			return false;
		}
		if (LMIICENMOBI != other.LMIICENMOBI)
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
		if (DHLDKLMPHNG != 0)
		{
			num ^= DHLDKLMPHNG.GetHashCode();
		}
		if (LMIICENMOBI != 0)
		{
			num ^= LMIICENMOBI.GetHashCode();
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
		if (DHLDKLMPHNG != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(DHLDKLMPHNG);
		}
		if (LMIICENMOBI != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LMIICENMOBI);
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
		if (DHLDKLMPHNG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHLDKLMPHNG);
		}
		if (LMIICENMOBI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LMIICENMOBI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(LFNDHPMOFLH other)
	{
		if (other != null)
		{
			if (other.DHLDKLMPHNG != 0)
			{
				DHLDKLMPHNG = other.DHLDKLMPHNG;
			}
			if (other.LMIICENMOBI != 0)
			{
				LMIICENMOBI = other.LMIICENMOBI;
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
			case 80u:
				DHLDKLMPHNG = input.ReadUInt32();
				break;
			case 96u:
				LMIICENMOBI = input.ReadUInt32();
				break;
			}
		}
	}
}
