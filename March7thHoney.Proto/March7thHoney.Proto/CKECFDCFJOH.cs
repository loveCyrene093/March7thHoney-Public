using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CKECFDCFJOH : IMessage<CKECFDCFJOH>, IMessage, IEquatable<CKECFDCFJOH>, IDeepCloneable<CKECFDCFJOH>, IBufferMessage
{
	private static readonly MessageParser<CKECFDCFJOH> _parser = new MessageParser<CKECFDCFJOH>(() => new CKECFDCFJOH());

	private UnknownFieldSet _unknownFields;

	public const int GAAGKLOHMPGFieldNumber = 2;

	private uint gAAGKLOHMPG_;

	public const int NAEFGFDPCFFFieldNumber = 14;

	private uint nAEFGFDPCFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CKECFDCFJOH> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CKECFDCFJOHReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GAAGKLOHMPG
	{
		get
		{
			return gAAGKLOHMPG_;
		}
		set
		{
			gAAGKLOHMPG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint NAEFGFDPCFF
	{
		get
		{
			return nAEFGFDPCFF_;
		}
		set
		{
			nAEFGFDPCFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH(CKECFDCFJOH other)
		: this()
	{
		gAAGKLOHMPG_ = other.gAAGKLOHMPG_;
		nAEFGFDPCFF_ = other.nAEFGFDPCFF_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CKECFDCFJOH Clone()
	{
		return new CKECFDCFJOH(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CKECFDCFJOH);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CKECFDCFJOH other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GAAGKLOHMPG != other.GAAGKLOHMPG)
		{
			return false;
		}
		if (NAEFGFDPCFF != other.NAEFGFDPCFF)
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
		if (GAAGKLOHMPG != 0)
		{
			num ^= GAAGKLOHMPG.GetHashCode();
		}
		if (NAEFGFDPCFF != 0)
		{
			num ^= NAEFGFDPCFF.GetHashCode();
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
		if (GAAGKLOHMPG != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(GAAGKLOHMPG);
		}
		if (NAEFGFDPCFF != 0)
		{
			output.WriteRawTag(112);
			output.WriteUInt32(NAEFGFDPCFF);
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
		if (GAAGKLOHMPG != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GAAGKLOHMPG);
		}
		if (NAEFGFDPCFF != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(NAEFGFDPCFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CKECFDCFJOH other)
	{
		if (other != null)
		{
			if (other.GAAGKLOHMPG != 0)
			{
				GAAGKLOHMPG = other.GAAGKLOHMPG;
			}
			if (other.NAEFGFDPCFF != 0)
			{
				NAEFGFDPCFF = other.NAEFGFDPCFF;
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
				GAAGKLOHMPG = input.ReadUInt32();
				break;
			case 112u:
				NAEFGFDPCFF = input.ReadUInt32();
				break;
			}
		}
	}
}
