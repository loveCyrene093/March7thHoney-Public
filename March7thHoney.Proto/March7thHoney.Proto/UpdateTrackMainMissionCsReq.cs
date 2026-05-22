using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateTrackMainMissionCsReq : IMessage<UpdateTrackMainMissionCsReq>, IMessage, IEquatable<UpdateTrackMainMissionCsReq>, IDeepCloneable<UpdateTrackMainMissionCsReq>, IBufferMessage
{
	private static readonly MessageParser<UpdateTrackMainMissionCsReq> _parser = new MessageParser<UpdateTrackMainMissionCsReq>(() => new UpdateTrackMainMissionCsReq());

	private UnknownFieldSet _unknownFields;

	public const int NILLMKMKODPFieldNumber = 1;

	private TrackMainMissionUpdateReasonId nILLMKMKODP_;

	public const int TrackMissionIdFieldNumber = 3;

	private uint trackMissionId_;

	public const int GNPDGLGBIMMFieldNumber = 4;

	private uint gNPDGLGBIMM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateTrackMainMissionCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateTrackMainMissionCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TrackMainMissionUpdateReasonId NILLMKMKODP
	{
		get
		{
			return nILLMKMKODP_;
		}
		set
		{
			nILLMKMKODP_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint TrackMissionId
	{
		get
		{
			return trackMissionId_;
		}
		set
		{
			trackMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint GNPDGLGBIMM
	{
		get
		{
			return gNPDGLGBIMM_;
		}
		set
		{
			gNPDGLGBIMM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTrackMainMissionCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTrackMainMissionCsReq(UpdateTrackMainMissionCsReq other)
		: this()
	{
		nILLMKMKODP_ = other.nILLMKMKODP_;
		trackMissionId_ = other.trackMissionId_;
		gNPDGLGBIMM_ = other.gNPDGLGBIMM_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTrackMainMissionCsReq Clone()
	{
		return new UpdateTrackMainMissionCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateTrackMainMissionCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateTrackMainMissionCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (NILLMKMKODP != other.NILLMKMKODP)
		{
			return false;
		}
		if (TrackMissionId != other.TrackMissionId)
		{
			return false;
		}
		if (GNPDGLGBIMM != other.GNPDGLGBIMM)
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
		if (NILLMKMKODP != TrackMainMissionUpdateReasonId.DjeoglfdjifDpdfiineaff)
		{
			num ^= NILLMKMKODP.GetHashCode();
		}
		if (TrackMissionId != 0)
		{
			num ^= TrackMissionId.GetHashCode();
		}
		if (GNPDGLGBIMM != 0)
		{
			num ^= GNPDGLGBIMM.GetHashCode();
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
		if (NILLMKMKODP != TrackMainMissionUpdateReasonId.DjeoglfdjifDpdfiineaff)
		{
			output.WriteRawTag(8);
			output.WriteEnum((int)NILLMKMKODP);
		}
		if (TrackMissionId != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(TrackMissionId);
		}
		if (GNPDGLGBIMM != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(GNPDGLGBIMM);
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
		if (NILLMKMKODP != TrackMainMissionUpdateReasonId.DjeoglfdjifDpdfiineaff)
		{
			num += 1 + CodedOutputStream.ComputeEnumSize((int)NILLMKMKODP);
		}
		if (TrackMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TrackMissionId);
		}
		if (GNPDGLGBIMM != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(GNPDGLGBIMM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateTrackMainMissionCsReq other)
	{
		if (other != null)
		{
			if (other.NILLMKMKODP != TrackMainMissionUpdateReasonId.DjeoglfdjifDpdfiineaff)
			{
				NILLMKMKODP = other.NILLMKMKODP;
			}
			if (other.TrackMissionId != 0)
			{
				TrackMissionId = other.TrackMissionId;
			}
			if (other.GNPDGLGBIMM != 0)
			{
				GNPDGLGBIMM = other.GNPDGLGBIMM;
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
				NILLMKMKODP = (TrackMainMissionUpdateReasonId)input.ReadEnum();
				break;
			case 24u:
				TrackMissionId = input.ReadUInt32();
				break;
			case 32u:
				GNPDGLGBIMM = input.ReadUInt32();
				break;
			}
		}
	}
}
