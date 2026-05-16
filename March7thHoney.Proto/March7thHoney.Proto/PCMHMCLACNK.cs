using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PCMHMCLACNK : IMessage<PCMHMCLACNK>, IMessage, IEquatable<PCMHMCLACNK>, IDeepCloneable<PCMHMCLACNK>, IBufferMessage
{
	private static readonly MessageParser<PCMHMCLACNK> _parser = new MessageParser<PCMHMCLACNK>(() => new PCMHMCLACNK());

	private UnknownFieldSet _unknownFields;

	public const int GPJHJOOIJJCFieldNumber = 5;

	private uint gPJHJOOIJJC_;

	public const int UidFieldNumber = 8;

	private uint uid_;

	public const int HHKCADKCLJCFieldNumber = 12;

	private ulong hHKCADKCLJC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PCMHMCLACNK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PCMHMCLACNKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPJHJOOIJJC
	{
		get
		{
			return gPJHJOOIJJC_;
		}
		set
		{
			gPJHJOOIJJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Uid
	{
		get
		{
			return uid_;
		}
		set
		{
			uid_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ulong HHKCADKCLJC
	{
		get
		{
			return hHKCADKCLJC_;
		}
		set
		{
			hHKCADKCLJC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCMHMCLACNK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCMHMCLACNK(PCMHMCLACNK other)
		: this()
	{
		gPJHJOOIJJC_ = other.gPJHJOOIJJC_;
		uid_ = other.uid_;
		hHKCADKCLJC_ = other.hHKCADKCLJC_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PCMHMCLACNK Clone()
	{
		return new PCMHMCLACNK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PCMHMCLACNK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PCMHMCLACNK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (GPJHJOOIJJC != other.GPJHJOOIJJC)
		{
			return false;
		}
		if (Uid != other.Uid)
		{
			return false;
		}
		if (HHKCADKCLJC != other.HHKCADKCLJC)
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
		if (GPJHJOOIJJC != 0)
		{
			num ^= GPJHJOOIJJC.GetHashCode();
		}
		if (Uid != 0)
		{
			num ^= Uid.GetHashCode();
		}
		if (HHKCADKCLJC != 0L)
		{
			num ^= HHKCADKCLJC.GetHashCode();
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
		if (GPJHJOOIJJC != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(GPJHJOOIJJC);
		}
		if (Uid != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Uid);
		}
		if (HHKCADKCLJC != 0L)
		{
			output.WriteRawTag(96);
			output.WriteUInt64(HHKCADKCLJC);
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
		if (GPJHJOOIJJC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPJHJOOIJJC);
		}
		if (Uid != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Uid);
		}
		if (HHKCADKCLJC != 0L)
		{
			num += 1 + CodedOutputStream.ComputeUInt64Size(HHKCADKCLJC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PCMHMCLACNK other)
	{
		if (other != null)
		{
			if (other.GPJHJOOIJJC != 0)
			{
				GPJHJOOIJJC = other.GPJHJOOIJJC;
			}
			if (other.Uid != 0)
			{
				Uid = other.Uid;
			}
			if (other.HHKCADKCLJC != 0L)
			{
				HHKCADKCLJC = other.HHKCADKCLJC;
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
			case 40u:
				GPJHJOOIJJC = input.ReadUInt32();
				break;
			case 64u:
				Uid = input.ReadUInt32();
				break;
			case 96u:
				HHKCADKCLJC = input.ReadUInt64();
				break;
			}
		}
	}
}
