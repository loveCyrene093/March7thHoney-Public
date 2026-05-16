using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KAONKHLDGPB : IMessage<KAONKHLDGPB>, IMessage, IEquatable<KAONKHLDGPB>, IDeepCloneable<KAONKHLDGPB>, IBufferMessage
{
	private static readonly MessageParser<KAONKHLDGPB> _parser = new MessageParser<KAONKHLDGPB>(() => new KAONKHLDGPB());

	private UnknownFieldSet _unknownFields;

	public const int AIKMPMKFMPHFieldNumber = 1;

	private uint aIKMPMKFMPH_;

	public const int IKKFDOHMCGMFieldNumber = 7;

	private uint iKKFDOHMCGM_;

	public const int AreaIdFieldNumber = 10;

	private uint areaId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KAONKHLDGPB> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KAONKHLDGPBReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AIKMPMKFMPH
	{
		get
		{
			return aIKMPMKFMPH_;
		}
		set
		{
			aIKMPMKFMPH_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint IKKFDOHMCGM
	{
		get
		{
			return iKKFDOHMCGM_;
		}
		set
		{
			iKKFDOHMCGM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint AreaId
	{
		get
		{
			return areaId_;
		}
		set
		{
			areaId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAONKHLDGPB()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAONKHLDGPB(KAONKHLDGPB other)
		: this()
	{
		aIKMPMKFMPH_ = other.aIKMPMKFMPH_;
		iKKFDOHMCGM_ = other.iKKFDOHMCGM_;
		areaId_ = other.areaId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KAONKHLDGPB Clone()
	{
		return new KAONKHLDGPB(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KAONKHLDGPB);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KAONKHLDGPB other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (AIKMPMKFMPH != other.AIKMPMKFMPH)
		{
			return false;
		}
		if (IKKFDOHMCGM != other.IKKFDOHMCGM)
		{
			return false;
		}
		if (AreaId != other.AreaId)
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
		if (AIKMPMKFMPH != 0)
		{
			num ^= AIKMPMKFMPH.GetHashCode();
		}
		if (IKKFDOHMCGM != 0)
		{
			num ^= IKKFDOHMCGM.GetHashCode();
		}
		if (AreaId != 0)
		{
			num ^= AreaId.GetHashCode();
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
		if (AIKMPMKFMPH != 0)
		{
			output.WriteRawTag(8);
			output.WriteUInt32(AIKMPMKFMPH);
		}
		if (IKKFDOHMCGM != 0)
		{
			output.WriteRawTag(56);
			output.WriteUInt32(IKKFDOHMCGM);
		}
		if (AreaId != 0)
		{
			output.WriteRawTag(80);
			output.WriteUInt32(AreaId);
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
		if (AIKMPMKFMPH != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AIKMPMKFMPH);
		}
		if (IKKFDOHMCGM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(IKKFDOHMCGM);
		}
		if (AreaId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(AreaId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KAONKHLDGPB other)
	{
		if (other != null)
		{
			if (other.AIKMPMKFMPH != 0)
			{
				AIKMPMKFMPH = other.AIKMPMKFMPH;
			}
			if (other.IKKFDOHMCGM != 0)
			{
				IKKFDOHMCGM = other.IKKFDOHMCGM;
			}
			if (other.AreaId != 0)
			{
				AreaId = other.AreaId;
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
				AIKMPMKFMPH = input.ReadUInt32();
				break;
			case 56u:
				IKKFDOHMCGM = input.ReadUInt32();
				break;
			case 80u:
				AreaId = input.ReadUInt32();
				break;
			}
		}
	}
}
