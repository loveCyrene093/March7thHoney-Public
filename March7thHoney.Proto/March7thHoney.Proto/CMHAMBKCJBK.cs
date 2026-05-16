using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class CMHAMBKCJBK : IMessage<CMHAMBKCJBK>, IMessage, IEquatable<CMHAMBKCJBK>, IDeepCloneable<CMHAMBKCJBK>, IBufferMessage
{
	private static readonly MessageParser<CMHAMBKCJBK> _parser = new MessageParser<CMHAMBKCJBK>(() => new CMHAMBKCJBK());

	private UnknownFieldSet _unknownFields;

	public const int PosFieldNumber = 1;

	private uint pos_;

	public const int JDPANINJAECFieldNumber = 2;

	private uint jDPANINJAEC_;

	public const int MMFPEGPHOECFieldNumber = 3;

	private uint mMFPEGPHOEC_;

	public const int DHNCNLFMOLIFieldNumber = 4;

	private uint dHNCNLFMOLI_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CMHAMBKCJBK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => CMHAMBKCJBKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Pos
	{
		get
		{
			return pos_;
		}
		set
		{
			pos_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JDPANINJAEC
	{
		get
		{
			return jDPANINJAEC_;
		}
		set
		{
			jDPANINJAEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MMFPEGPHOEC
	{
		get
		{
			return mMFPEGPHOEC_;
		}
		set
		{
			mMFPEGPHOEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DHNCNLFMOLI
	{
		get
		{
			return dHNCNLFMOLI_;
		}
		set
		{
			dHNCNLFMOLI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMHAMBKCJBK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMHAMBKCJBK(CMHAMBKCJBK other)
		: this()
	{
		pos_ = other.pos_;
		jDPANINJAEC_ = other.jDPANINJAEC_;
		mMFPEGPHOEC_ = other.mMFPEGPHOEC_;
		dHNCNLFMOLI_ = other.dHNCNLFMOLI_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CMHAMBKCJBK Clone()
	{
		return new CMHAMBKCJBK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as CMHAMBKCJBK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CMHAMBKCJBK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Pos != other.Pos)
		{
			return false;
		}
		if (JDPANINJAEC != other.JDPANINJAEC)
		{
			return false;
		}
		if (MMFPEGPHOEC != other.MMFPEGPHOEC)
		{
			return false;
		}
		if (DHNCNLFMOLI != other.DHNCNLFMOLI)
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
		if (Pos != 0)
		{
			num ^= Pos.GetHashCode();
		}
		if (JDPANINJAEC != 0)
		{
			num ^= JDPANINJAEC.GetHashCode();
		}
		if (MMFPEGPHOEC != 0)
		{
			num ^= MMFPEGPHOEC.GetHashCode();
		}
		if (DHNCNLFMOLI != 0)
		{
			num ^= DHNCNLFMOLI.GetHashCode();
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
		if (Pos != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(Pos);
		}
		if (JDPANINJAEC != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(JDPANINJAEC);
		}
		if (MMFPEGPHOEC != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(MMFPEGPHOEC);
		}
		if (DHNCNLFMOLI != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(DHNCNLFMOLI);
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
		if (Pos != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Pos);
		}
		if (JDPANINJAEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JDPANINJAEC);
		}
		if (MMFPEGPHOEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MMFPEGPHOEC);
		}
		if (DHNCNLFMOLI != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DHNCNLFMOLI);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CMHAMBKCJBK other)
	{
		if (other != null)
		{
			if (other.Pos != 0)
			{
				Pos = other.Pos;
			}
			if (other.JDPANINJAEC != 0)
			{
				JDPANINJAEC = other.JDPANINJAEC;
			}
			if (other.MMFPEGPHOEC != 0)
			{
				MMFPEGPHOEC = other.MMFPEGPHOEC;
			}
			if (other.DHNCNLFMOLI != 0)
			{
				DHNCNLFMOLI = other.DHNCNLFMOLI;
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
				Pos = input.ReadUInt32();
				break;
			case 16u:
				JDPANINJAEC = input.ReadUInt32();
				break;
			case 24u:
				MMFPEGPHOEC = input.ReadUInt32();
				break;
			case 32u:
				DHNCNLFMOLI = input.ReadUInt32();
				break;
			}
		}
	}
}
