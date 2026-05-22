using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MusicRhythmSaveSongConfigDataCsReq : IMessage<MusicRhythmSaveSongConfigDataCsReq>, IMessage, IEquatable<MusicRhythmSaveSongConfigDataCsReq>, IDeepCloneable<MusicRhythmSaveSongConfigDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<MusicRhythmSaveSongConfigDataCsReq> _parser = new MessageParser<MusicRhythmSaveSongConfigDataCsReq>(() => new MusicRhythmSaveSongConfigDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BAJEIALIBBMFieldNumber = 14;

	private MusicRhythmGroup bAJEIALIBBM_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MusicRhythmSaveSongConfigDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MusicRhythmSaveSongConfigDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmGroup BAJEIALIBBM
	{
		get
		{
			return bAJEIALIBBM_;
		}
		set
		{
			bAJEIALIBBM_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataCsReq(MusicRhythmSaveSongConfigDataCsReq other)
		: this()
	{
		bAJEIALIBBM_ = ((other.bAJEIALIBBM_ != null) ? other.bAJEIALIBBM_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MusicRhythmSaveSongConfigDataCsReq Clone()
	{
		return new MusicRhythmSaveSongConfigDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MusicRhythmSaveSongConfigDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MusicRhythmSaveSongConfigDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(BAJEIALIBBM, other.BAJEIALIBBM))
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
		if (bAJEIALIBBM_ != null)
		{
			num ^= BAJEIALIBBM.GetHashCode();
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
		if (bAJEIALIBBM_ != null)
		{
			output.WriteRawTag(114);
			output.WriteMessage(BAJEIALIBBM);
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
		if (bAJEIALIBBM_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(BAJEIALIBBM);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MusicRhythmSaveSongConfigDataCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.bAJEIALIBBM_ != null)
		{
			if (bAJEIALIBBM_ == null)
			{
				BAJEIALIBBM = new MusicRhythmGroup();
			}
			BAJEIALIBBM.MergeFrom(other.BAJEIALIBBM);
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
			if (num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (bAJEIALIBBM_ == null)
			{
				BAJEIALIBBM = new MusicRhythmGroup();
			}
			input.ReadMessage(BAJEIALIBBM);
		}
	}
}
