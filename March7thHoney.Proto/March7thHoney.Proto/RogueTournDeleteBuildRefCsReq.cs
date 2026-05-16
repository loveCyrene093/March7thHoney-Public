using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class RogueTournDeleteBuildRefCsReq : IMessage<RogueTournDeleteBuildRefCsReq>, IMessage, IEquatable<RogueTournDeleteBuildRefCsReq>, IDeepCloneable<RogueTournDeleteBuildRefCsReq>, IBufferMessage
{
	private static readonly MessageParser<RogueTournDeleteBuildRefCsReq> _parser = new MessageParser<RogueTournDeleteBuildRefCsReq>(() => new RogueTournDeleteBuildRefCsReq());

	private UnknownFieldSet _unknownFields;

	public const int IBJMBIACFEKFieldNumber = 14;

	private static readonly FieldCodec<uint> _repeated_iBJMBIACFEK_codec = FieldCodec.ForUInt32(114u);

	private readonly RepeatedField<uint> iBJMBIACFEK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RogueTournDeleteBuildRefCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => RogueTournDeleteBuildRefCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> IBJMBIACFEK => iBJMBIACFEK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournDeleteBuildRefCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournDeleteBuildRefCsReq(RogueTournDeleteBuildRefCsReq other)
		: this()
	{
		iBJMBIACFEK_ = other.iBJMBIACFEK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RogueTournDeleteBuildRefCsReq Clone()
	{
		return new RogueTournDeleteBuildRefCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as RogueTournDeleteBuildRefCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(RogueTournDeleteBuildRefCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!iBJMBIACFEK_.Equals(other.iBJMBIACFEK_))
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
		num ^= iBJMBIACFEK_.GetHashCode();
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
		iBJMBIACFEK_.WriteTo(ref output, _repeated_iBJMBIACFEK_codec);
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
		num += iBJMBIACFEK_.CalculateSize(_repeated_iBJMBIACFEK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RogueTournDeleteBuildRefCsReq other)
	{
		if (other != null)
		{
			iBJMBIACFEK_.Add(other.iBJMBIACFEK_);
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
			if (num != 112 && num != 114)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				iBJMBIACFEK_.AddEntriesFrom(ref input, _repeated_iBJMBIACFEK_codec);
			}
		}
	}
}
