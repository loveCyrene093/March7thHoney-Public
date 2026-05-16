using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ELLNDNEBHDK : IMessage<ELLNDNEBHDK>, IMessage, IEquatable<ELLNDNEBHDK>, IDeepCloneable<ELLNDNEBHDK>, IBufferMessage
{
	private static readonly MessageParser<ELLNDNEBHDK> _parser = new MessageParser<ELLNDNEBHDK>(() => new ELLNDNEBHDK());

	private UnknownFieldSet _unknownFields;

	public const int OCLLADBFKHPFieldNumber = 3;

	private JEHNBDDMIEJ oCLLADBFKHP_;

	public const int LGPPFKDKHECFieldNumber = 4;

	private uint lGPPFKDKHEC_;

	public const int OCINKMOAMOMFieldNumber = 6;

	private uint oCINKMOAMOM_;

	public const int StatusFieldNumber = 8;

	private uint status_;

	public const int IHEJOGHDPMIFieldNumber = 11;

	private double iHEJOGHDPMI_;

	public const int ScoreIdFieldNumber = 12;

	private uint scoreId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ELLNDNEBHDK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ELLNDNEBHDKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JEHNBDDMIEJ OCLLADBFKHP
	{
		get
		{
			return oCLLADBFKHP_;
		}
		set
		{
			oCLLADBFKHP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint LGPPFKDKHEC
	{
		get
		{
			return lGPPFKDKHEC_;
		}
		set
		{
			lGPPFKDKHEC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint OCINKMOAMOM
	{
		get
		{
			return oCINKMOAMOM_;
		}
		set
		{
			oCINKMOAMOM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Status
	{
		get
		{
			return status_;
		}
		set
		{
			status_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public double IHEJOGHDPMI
	{
		get
		{
			return iHEJOGHDPMI_;
		}
		set
		{
			iHEJOGHDPMI_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint ScoreId
	{
		get
		{
			return scoreId_;
		}
		set
		{
			scoreId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELLNDNEBHDK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELLNDNEBHDK(ELLNDNEBHDK other)
		: this()
	{
		oCLLADBFKHP_ = ((other.oCLLADBFKHP_ != null) ? other.oCLLADBFKHP_.Clone() : null);
		lGPPFKDKHEC_ = other.lGPPFKDKHEC_;
		oCINKMOAMOM_ = other.oCINKMOAMOM_;
		status_ = other.status_;
		iHEJOGHDPMI_ = other.iHEJOGHDPMI_;
		scoreId_ = other.scoreId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ELLNDNEBHDK Clone()
	{
		return new ELLNDNEBHDK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ELLNDNEBHDK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ELLNDNEBHDK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OCLLADBFKHP, other.OCLLADBFKHP))
		{
			return false;
		}
		if (LGPPFKDKHEC != other.LGPPFKDKHEC)
		{
			return false;
		}
		if (OCINKMOAMOM != other.OCINKMOAMOM)
		{
			return false;
		}
		if (Status != other.Status)
		{
			return false;
		}
		if (!ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(IHEJOGHDPMI, other.IHEJOGHDPMI))
		{
			return false;
		}
		if (ScoreId != other.ScoreId)
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
		if (oCLLADBFKHP_ != null)
		{
			num ^= OCLLADBFKHP.GetHashCode();
		}
		if (LGPPFKDKHEC != 0)
		{
			num ^= LGPPFKDKHEC.GetHashCode();
		}
		if (OCINKMOAMOM != 0)
		{
			num ^= OCINKMOAMOM.GetHashCode();
		}
		if (Status != 0)
		{
			num ^= Status.GetHashCode();
		}
		if (IHEJOGHDPMI != 0.0)
		{
			num ^= ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(IHEJOGHDPMI);
		}
		if (ScoreId != 0)
		{
			num ^= ScoreId.GetHashCode();
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
		if (oCLLADBFKHP_ != null)
		{
			output.WriteRawTag(26);
			output.WriteMessage(OCLLADBFKHP);
		}
		if (LGPPFKDKHEC != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(LGPPFKDKHEC);
		}
		if (OCINKMOAMOM != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(OCINKMOAMOM);
		}
		if (Status != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Status);
		}
		if (IHEJOGHDPMI != 0.0)
		{
			output.WriteRawTag(89);
			output.WriteDouble(IHEJOGHDPMI);
		}
		if (ScoreId != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(ScoreId);
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
		if (oCLLADBFKHP_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OCLLADBFKHP);
		}
		if (LGPPFKDKHEC != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(LGPPFKDKHEC);
		}
		if (OCINKMOAMOM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(OCINKMOAMOM);
		}
		if (Status != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Status);
		}
		if (IHEJOGHDPMI != 0.0)
		{
			num += 9;
		}
		if (ScoreId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(ScoreId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ELLNDNEBHDK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oCLLADBFKHP_ != null)
		{
			if (oCLLADBFKHP_ == null)
			{
				OCLLADBFKHP = new JEHNBDDMIEJ();
			}
			OCLLADBFKHP.MergeFrom(other.OCLLADBFKHP);
		}
		if (other.LGPPFKDKHEC != 0)
		{
			LGPPFKDKHEC = other.LGPPFKDKHEC;
		}
		if (other.OCINKMOAMOM != 0)
		{
			OCINKMOAMOM = other.OCINKMOAMOM;
		}
		if (other.Status != 0)
		{
			Status = other.Status;
		}
		if (other.IHEJOGHDPMI != 0.0)
		{
			IHEJOGHDPMI = other.IHEJOGHDPMI;
		}
		if (other.ScoreId != 0)
		{
			ScoreId = other.ScoreId;
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
			case 26u:
				if (oCLLADBFKHP_ == null)
				{
					OCLLADBFKHP = new JEHNBDDMIEJ();
				}
				input.ReadMessage(OCLLADBFKHP);
				break;
			case 32u:
				LGPPFKDKHEC = input.ReadUInt32();
				break;
			case 48u:
				OCINKMOAMOM = input.ReadUInt32();
				break;
			case 64u:
				Status = input.ReadUInt32();
				break;
			case 89u:
				IHEJOGHDPMI = input.ReadDouble();
				break;
			case 96u:
				ScoreId = input.ReadUInt32();
				break;
			}
		}
	}
}
