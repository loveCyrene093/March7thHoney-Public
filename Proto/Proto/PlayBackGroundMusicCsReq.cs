using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlayBackGroundMusicCsReq : IMessage<PlayBackGroundMusicCsReq>, IMessage, IEquatable<PlayBackGroundMusicCsReq>, IDeepCloneable<PlayBackGroundMusicCsReq>, IBufferMessage
{
	private static readonly MessageParser<PlayBackGroundMusicCsReq> _parser = new MessageParser<PlayBackGroundMusicCsReq>(() => new PlayBackGroundMusicCsReq());

	private UnknownFieldSet _unknownFields;

	public const int DMGCIDGKPFFFieldNumber = 10;

	private MCPPIEJEBEF dMGCIDGKPFF_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlayBackGroundMusicCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlayBackGroundMusicCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MCPPIEJEBEF DMGCIDGKPFF
	{
		get
		{
			return dMGCIDGKPFF_;
		}
		set
		{
			dMGCIDGKPFF_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayBackGroundMusicCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayBackGroundMusicCsReq(PlayBackGroundMusicCsReq other)
		: this()
	{
		dMGCIDGKPFF_ = ((other.dMGCIDGKPFF_ != null) ? other.dMGCIDGKPFF_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayBackGroundMusicCsReq Clone()
	{
		return new PlayBackGroundMusicCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlayBackGroundMusicCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlayBackGroundMusicCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DMGCIDGKPFF, other.DMGCIDGKPFF))
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
		if (dMGCIDGKPFF_ != null)
		{
			num ^= DMGCIDGKPFF.GetHashCode();
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
		if (dMGCIDGKPFF_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(DMGCIDGKPFF);
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
		if (dMGCIDGKPFF_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DMGCIDGKPFF);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlayBackGroundMusicCsReq other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dMGCIDGKPFF_ != null)
		{
			if (dMGCIDGKPFF_ == null)
			{
				DMGCIDGKPFF = new MCPPIEJEBEF();
			}
			DMGCIDGKPFF.MergeFrom(other.DMGCIDGKPFF);
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
			if (num != 82)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				continue;
			}
			if (dMGCIDGKPFF_ == null)
			{
				DMGCIDGKPFF = new MCPPIEJEBEF();
			}
			input.ReadMessage(DMGCIDGKPFF);
		}
	}
}
