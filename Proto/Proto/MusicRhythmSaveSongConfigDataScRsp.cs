using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmSaveSongConfigDataScRsp : IMessage<MusicRhythmSaveSongConfigDataScRsp>, IMessage, IEquatable<MusicRhythmSaveSongConfigDataScRsp>, IDeepCloneable<MusicRhythmSaveSongConfigDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmSaveSongConfigDataScRsp> _parser = new MessageParser<MusicRhythmSaveSongConfigDataScRsp>(() => new MusicRhythmSaveSongConfigDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int DMKIGOLBGHEFieldNumber = 3;

	private uint dMKIGOLBGHE_;

	public const int RetcodeFieldNumber = 12;

	private uint retcode_;

	public const int HNEDAOLNAGOFieldNumber = 13;

	private uint hNEDAOLNAGO_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmSaveSongConfigDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmSaveSongConfigDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public uint DMKIGOLBGHE
	{
		get
		{
			return dMKIGOLBGHE_;
		}
		set
		{
			dMKIGOLBGHE_ = value;
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
	public uint HNEDAOLNAGO
	{
		get
		{
			return hNEDAOLNAGO_;
		}
		set
		{
			hNEDAOLNAGO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataScRsp(MusicRhythmSaveSongConfigDataScRsp other)
		: this()
	{
		dMKIGOLBGHE_ = other.dMKIGOLBGHE_;
		retcode_ = other.retcode_;
		hNEDAOLNAGO_ = other.hNEDAOLNAGO_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataScRsp Clone()
	{
		return new MusicRhythmSaveSongConfigDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmSaveSongConfigDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmSaveSongConfigDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (DMKIGOLBGHE != other.DMKIGOLBGHE)
		{
			return false;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (HNEDAOLNAGO != other.HNEDAOLNAGO)
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
		if (DMKIGOLBGHE != 0)
		{
			num ^= DMKIGOLBGHE.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (HNEDAOLNAGO != 0)
		{
			num ^= HNEDAOLNAGO.GetHashCode();
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
		if (DMKIGOLBGHE != 0)
		{
			output.WriteRawTag(24);
			output.WriteUInt32(DMKIGOLBGHE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(96);
			output.WriteUInt32(Retcode);
		}
		if (HNEDAOLNAGO != 0)
		{
			output.WriteRawTag(104);
			output.WriteUInt32(HNEDAOLNAGO);
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
		if (DMKIGOLBGHE != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(DMKIGOLBGHE);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (HNEDAOLNAGO != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(HNEDAOLNAGO);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmSaveSongConfigDataScRsp other)
	{
		if (other != null)
		{
			if (other.DMKIGOLBGHE != 0)
			{
				DMKIGOLBGHE = other.DMKIGOLBGHE;
			}
			if (other.Retcode != 0)
			{
				Retcode = other.Retcode;
			}
			if (other.HNEDAOLNAGO != 0)
			{
				HNEDAOLNAGO = other.HNEDAOLNAGO;
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
			case 24u:
				DMKIGOLBGHE = input.ReadUInt32();
				break;
			case 96u:
				Retcode = input.ReadUInt32();
				break;
			case 104u:
				HNEDAOLNAGO = input.ReadUInt32();
				break;
			}
		}
	}
}
