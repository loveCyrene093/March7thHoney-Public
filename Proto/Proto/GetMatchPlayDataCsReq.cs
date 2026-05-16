using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class GetMatchPlayDataCsReq : IMessage<GetMatchPlayDataCsReq>, IMessage, IEquatable<GetMatchPlayDataCsReq>, IDeepCloneable<GetMatchPlayDataCsReq>, IBufferMessage
{
	private static readonly MessageParser<GetMatchPlayDataCsReq> _parser = new MessageParser<GetMatchPlayDataCsReq>(() => new GetMatchPlayDataCsReq());

	private UnknownFieldSet _unknownFields;

	public const int BFBJKAALFHDFieldNumber = 8;

	private static readonly FieldCodec<FightGameMode> _repeated_bFBJKAALFHD_codec = FieldCodec.ForEnum(66u, (FightGameMode x) => (int)x, (int x) => (FightGameMode)x);

	private readonly RepeatedField<FightGameMode> bFBJKAALFHD_ = new RepeatedField<FightGameMode>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GetMatchPlayDataCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => GetMatchPlayDataCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<FightGameMode> BFBJKAALFHD => bFBJKAALFHD_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMatchPlayDataCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMatchPlayDataCsReq(GetMatchPlayDataCsReq other)
		: this()
	{
		bFBJKAALFHD_ = other.bFBJKAALFHD_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GetMatchPlayDataCsReq Clone()
	{
		return new GetMatchPlayDataCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as GetMatchPlayDataCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GetMatchPlayDataCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!bFBJKAALFHD_.Equals(other.bFBJKAALFHD_))
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
		num ^= bFBJKAALFHD_.GetHashCode();
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
		bFBJKAALFHD_.WriteTo(ref output, _repeated_bFBJKAALFHD_codec);
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
		num += bFBJKAALFHD_.CalculateSize(_repeated_bFBJKAALFHD_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GetMatchPlayDataCsReq other)
	{
		if (other != null)
		{
			bFBJKAALFHD_.Add(other.bFBJKAALFHD_);
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
			if (num != 64 && num != 66)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				bFBJKAALFHD_.AddEntriesFrom(ref input, _repeated_bFBJKAALFHD_codec);
			}
		}
	}
}
