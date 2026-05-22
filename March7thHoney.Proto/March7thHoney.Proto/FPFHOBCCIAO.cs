using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class FPFHOBCCIAO : IMessage<FPFHOBCCIAO>, IMessage, IEquatable<FPFHOBCCIAO>, IDeepCloneable<FPFHOBCCIAO>, IBufferMessage
{
	private static readonly MessageParser<FPFHOBCCIAO> _parser = new MessageParser<FPFHOBCCIAO>(() => new FPFHOBCCIAO());

	private UnknownFieldSet _unknownFields;

	public const int LevelFieldNumber = 1;

	private uint level_;

	public const int GPOLGIGNPICFieldNumber = 6;

	private uint gPOLGIGNPIC_;

	public const int KLAAFEIMAMIFieldNumber = 8;

	private uint kLAAFEIMAMI_;

	public const int LJBHHIDILONFieldNumber = 12;

	private uint lJBHHIDILON_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FPFHOBCCIAO> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => FPFHOBCCIAOReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Level
	{
		get
		{
			return level_;
		}
		set
		{
			level_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GPOLGIGNPIC
	{
		get
		{
			return gPOLGIGNPIC_;
		}
		set
		{
			gPOLGIGNPIC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint KLAAFEIMAMI
	{
		get
		{
			return kLAAFEIMAMI_;
		}
		set
		{
			kLAAFEIMAMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LJBHHIDILON
	{
		get
		{
			return lJBHHIDILON_;
		}
		set
		{
			lJBHHIDILON_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFHOBCCIAO()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFHOBCCIAO(FPFHOBCCIAO other)
		: this()
	{
		level_ = other.level_;
		gPOLGIGNPIC_ = other.gPOLGIGNPIC_;
		kLAAFEIMAMI_ = other.kLAAFEIMAMI_;
		lJBHHIDILON_ = other.lJBHHIDILON_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FPFHOBCCIAO Clone()
	{
		return new FPFHOBCCIAO(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as FPFHOBCCIAO);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FPFHOBCCIAO other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Level != other.Level)
		{
			return false;
		}
		if (GPOLGIGNPIC != other.GPOLGIGNPIC)
		{
			return false;
		}
		if (KLAAFEIMAMI != other.KLAAFEIMAMI)
		{
			return false;
		}
		if (LJBHHIDILON != other.LJBHHIDILON)
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
		if (Level != 0)
		{
			num ^= Level.GetHashCode();
		}
		if (GPOLGIGNPIC != 0)
		{
			num ^= GPOLGIGNPIC.GetHashCode();
		}
		if (KLAAFEIMAMI != 0)
		{
			num ^= KLAAFEIMAMI.GetHashCode();
		}
		if (LJBHHIDILON != 0)
		{
			num ^= LJBHHIDILON.GetHashCode();
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
		if (Level != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Level);
		}
		if (GPOLGIGNPIC != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(GPOLGIGNPIC);
		}
		if (KLAAFEIMAMI != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(KLAAFEIMAMI);
		}
		if (LJBHHIDILON != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(LJBHHIDILON);
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
		if (Level != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Level);
		}
		if (GPOLGIGNPIC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GPOLGIGNPIC);
		}
		if (KLAAFEIMAMI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(KLAAFEIMAMI);
		}
		if (LJBHHIDILON != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LJBHHIDILON);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FPFHOBCCIAO other)
	{
		if (other != null)
		{
			if (other.Level != 0)
			{
				Level = other.Level;
			}
			if (other.GPOLGIGNPIC != 0)
			{
				GPOLGIGNPIC = other.GPOLGIGNPIC;
			}
			if (other.KLAAFEIMAMI != 0)
			{
				KLAAFEIMAMI = other.KLAAFEIMAMI;
			}
			if (other.LJBHHIDILON != 0)
			{
				LJBHHIDILON = other.LJBHHIDILON;
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
				Level = input.ReadUInt32();
				break;
			case 48u:
				GPOLGIGNPIC = input.ReadUInt32();
				break;
			case 64u:
				KLAAFEIMAMI = input.ReadUInt32();
				break;
			case 96u:
				LJBHHIDILON = input.ReadUInt32();
				break;
			}
		}
	}
}
