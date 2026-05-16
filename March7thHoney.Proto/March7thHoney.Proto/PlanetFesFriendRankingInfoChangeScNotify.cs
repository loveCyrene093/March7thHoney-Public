using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class PlanetFesFriendRankingInfoChangeScNotify : IMessage<PlanetFesFriendRankingInfoChangeScNotify>, IMessage, IEquatable<PlanetFesFriendRankingInfoChangeScNotify>, IDeepCloneable<PlanetFesFriendRankingInfoChangeScNotify>, IBufferMessage
{
	private static readonly MessageParser<PlanetFesFriendRankingInfoChangeScNotify> _parser = new MessageParser<PlanetFesFriendRankingInfoChangeScNotify>(() => new PlanetFesFriendRankingInfoChangeScNotify());

	private UnknownFieldSet _unknownFields;

	public const int CPBGLNGOCBAFieldNumber = 1;

	private static readonly FieldCodec<FFFKFKHHEOG> _repeated_cPBGLNGOCBA_codec = FieldCodec.ForMessage(10u, FFFKFKHHEOG.Parser);

	private readonly RepeatedField<FFFKFKHHEOG> cPBGLNGOCBA_ = new RepeatedField<FFFKFKHHEOG>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PlanetFesFriendRankingInfoChangeScNotify> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => PlanetFesFriendRankingInfoChangeScNotifyReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FFFKFKHHEOG> CPBGLNGOCBA => cPBGLNGOCBA_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesFriendRankingInfoChangeScNotify()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesFriendRankingInfoChangeScNotify(PlanetFesFriendRankingInfoChangeScNotify other)
		: this()
	{
		cPBGLNGOCBA_ = other.cPBGLNGOCBA_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlanetFesFriendRankingInfoChangeScNotify Clone()
	{
		return new PlanetFesFriendRankingInfoChangeScNotify(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as PlanetFesFriendRankingInfoChangeScNotify);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PlanetFesFriendRankingInfoChangeScNotify other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cPBGLNGOCBA_.Equals(other.cPBGLNGOCBA_))
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
		num ^= cPBGLNGOCBA_.GetHashCode();
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
		cPBGLNGOCBA_.WriteTo(ref output, _repeated_cPBGLNGOCBA_codec);
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
		num += cPBGLNGOCBA_.CalculateSize(_repeated_cPBGLNGOCBA_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PlanetFesFriendRankingInfoChangeScNotify other)
	{
		if (other != null)
		{
			cPBGLNGOCBA_.Add(other.cPBGLNGOCBA_);
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
			if (num != 10)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cPBGLNGOCBA_.AddEntriesFrom(ref input, _repeated_cPBGLNGOCBA_codec);
			}
		}
	}
}
