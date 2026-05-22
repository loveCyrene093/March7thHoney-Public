using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateTrackMainMissionScRsp : IMessage<UpdateTrackMainMissionScRsp>, IMessage, IEquatable<UpdateTrackMainMissionScRsp>, IDeepCloneable<UpdateTrackMainMissionScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpdateTrackMainMissionScRsp> _parser = new MessageParser<UpdateTrackMainMissionScRsp>(() => new UpdateTrackMainMissionScRsp());

	private UnknownFieldSet _unknownFields;

	public const int PrevTrackMissionIdFieldNumber = 4;

	private uint prevTrackMissionId_;

	public const int RetcodeFieldNumber = 9;

	private uint retcode_;

	public const int TrackMissionIdFieldNumber = 13;

	private uint trackMissionId_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateTrackMainMissionScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateTrackMainMissionScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint PrevTrackMissionId
	{
		get
		{
			return prevTrackMissionId_;
		}
		set
		{
			prevTrackMissionId_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint Retcode
	{
		get
		{
			return retcode_;
		}
		set
		{
			retcode_ = value;
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
	public UpdateTrackMainMissionScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTrackMainMissionScRsp(UpdateTrackMainMissionScRsp other)
		: this()
	{
		prevTrackMissionId_ = other.prevTrackMissionId_;
		retcode_ = other.retcode_;
		trackMissionId_ = other.trackMissionId_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateTrackMainMissionScRsp Clone()
	{
		return new UpdateTrackMainMissionScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateTrackMainMissionScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateTrackMainMissionScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (PrevTrackMissionId != other.PrevTrackMissionId)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (TrackMissionId != other.TrackMissionId)
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
		if (PrevTrackMissionId != 0)
		{
			num ^= PrevTrackMissionId.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (TrackMissionId != 0)
		{
			num ^= TrackMissionId.GetHashCode();
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
		if (PrevTrackMissionId != 0)
		{
			output.WriteRawTag(32);
			output.WriteUInt32(PrevTrackMissionId);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(72);
			output.WriteUInt32(Retcode);
		}
		if (TrackMissionId != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(TrackMissionId);
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
		if (PrevTrackMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(PrevTrackMissionId);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (TrackMissionId != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(TrackMissionId);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateTrackMainMissionScRsp other)
	{
		if (other != null)
		{
			if (other.PrevTrackMissionId != 0)
			{
				PrevTrackMissionId = other.PrevTrackMissionId;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.TrackMissionId != 0)
			{
				TrackMissionId = other.TrackMissionId;
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
			case 32u:
				PrevTrackMissionId = input.ReadUInt32();
				break;
			case 72u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				TrackMissionId = input.ReadUInt32();
				break;
			}
		}
	}
}
