using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class BGKNEEHCGEB : IMessage<BGKNEEHCGEB>, IMessage, IEquatable<BGKNEEHCGEB>, IDeepCloneable<BGKNEEHCGEB>, IBufferMessage
{
	private static readonly MessageParser<BGKNEEHCGEB> _parser = new MessageParser<BGKNEEHCGEB>(() => new BGKNEEHCGEB());

	private UnknownFieldSet _unknownFields;

	public const int JHLGEDGMPGEFieldNumber = 1;

	private uint jHLGEDGMPGE_;

	public const int MGFOHPHEHAPFieldNumber = 2;

	private uint mGFOHPHEHAP_;

	public const int CCMLPIEILEGFieldNumber = 3;

	private double cCMLPIEILEG_;

	public const int WaveFieldNumber = 4;

	private uint wave_;

	public const int IBFBGEFLOJKFieldNumber = 5;

	private uint iBFBGEFLOJK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BGKNEEHCGEB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => BGKNEEHCGEBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint JHLGEDGMPGE
	{
		get
		{
			return jHLGEDGMPGE_;
		}
		set
		{
			jHLGEDGMPGE_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint MGFOHPHEHAP
	{
		get
		{
			return mGFOHPHEHAP_;
		}
		set
		{
			mGFOHPHEHAP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double CCMLPIEILEG
	{
		get
		{
			return cCMLPIEILEG_;
		}
		set
		{
			cCMLPIEILEG_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Wave
	{
		get
		{
			return wave_;
		}
		set
		{
			wave_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IBFBGEFLOJK
	{
		get
		{
			return iBFBGEFLOJK_;
		}
		set
		{
			iBFBGEFLOJK_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKNEEHCGEB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKNEEHCGEB(BGKNEEHCGEB other)
		: this()
	{
		jHLGEDGMPGE_ = other.jHLGEDGMPGE_;
		mGFOHPHEHAP_ = other.mGFOHPHEHAP_;
		cCMLPIEILEG_ = other.cCMLPIEILEG_;
		wave_ = other.wave_;
		iBFBGEFLOJK_ = other.iBFBGEFLOJK_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BGKNEEHCGEB Clone()
	{
		return new BGKNEEHCGEB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as BGKNEEHCGEB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BGKNEEHCGEB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (JHLGEDGMPGE != other.JHLGEDGMPGE)
		{
			return false;
		}
		if (MGFOHPHEHAP != other.MGFOHPHEHAP)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(CCMLPIEILEG, other.CCMLPIEILEG))
		{
			return false;
		}
		if (Wave != other.Wave)
		{
			return false;
		}
		if (IBFBGEFLOJK != other.IBFBGEFLOJK)
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
		if (JHLGEDGMPGE != 0)
		{
			num ^= JHLGEDGMPGE.GetHashCode();
		}
		if (MGFOHPHEHAP != 0)
		{
			num ^= MGFOHPHEHAP.GetHashCode();
		}
		if (CCMLPIEILEG != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(CCMLPIEILEG);
		}
		if (Wave != 0)
		{
			num ^= Wave.GetHashCode();
		}
		if (IBFBGEFLOJK != 0)
		{
			num ^= IBFBGEFLOJK.GetHashCode();
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
		if (JHLGEDGMPGE != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(JHLGEDGMPGE);
		}
		if (MGFOHPHEHAP != 0)
		{
			output.WriteRawTag(16);
			output.WriteUInt32(MGFOHPHEHAP);
		}
		if (CCMLPIEILEG != 0.0)
		{
			output.WriteRawTag(25);
			output.WriteDouble(CCMLPIEILEG);
		}
		if (Wave != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(Wave);
		}
		if (IBFBGEFLOJK != 0)
		{
			output.WriteRawTag(40);
			output.WriteUInt32(IBFBGEFLOJK);
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
		if (JHLGEDGMPGE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(JHLGEDGMPGE);
		}
		if (MGFOHPHEHAP != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(MGFOHPHEHAP);
		}
		if (CCMLPIEILEG != 0.0)
		{
			num += 9;
		}
		if (Wave != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Wave);
		}
		if (IBFBGEFLOJK != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IBFBGEFLOJK);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BGKNEEHCGEB other)
	{
		if (other != null)
		{
			if (other.JHLGEDGMPGE != 0)
			{
				JHLGEDGMPGE = other.JHLGEDGMPGE;
			}
			if (other.MGFOHPHEHAP != 0)
			{
				MGFOHPHEHAP = other.MGFOHPHEHAP;
			}
			if (other.CCMLPIEILEG != 0.0)
			{
				CCMLPIEILEG = other.CCMLPIEILEG;
			}
			if (other.Wave != 0)
			{
				Wave = other.Wave;
			}
			if (other.IBFBGEFLOJK != 0)
			{
				IBFBGEFLOJK = other.IBFBGEFLOJK;
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
				JHLGEDGMPGE = input.ReadUInt32();
				break;
			case 16u:
				MGFOHPHEHAP = input.ReadUInt32();
				break;
			case 25u:
				CCMLPIEILEG = input.ReadDouble();
				break;
			case 32u:
				Wave = input.ReadUInt32();
				break;
			case 40u:
				IBFBGEFLOJK = input.ReadUInt32();
				break;
			}
		}
	}
}
