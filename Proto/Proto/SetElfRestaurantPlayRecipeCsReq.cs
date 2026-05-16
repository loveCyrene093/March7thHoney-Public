using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class SetElfRestaurantPlayRecipeCsReq : IMessage<SetElfRestaurantPlayRecipeCsReq>, IMessage, IEquatable<SetElfRestaurantPlayRecipeCsReq>, IDeepCloneable<SetElfRestaurantPlayRecipeCsReq>, IBufferMessage
{
	private static readonly MessageParser<SetElfRestaurantPlayRecipeCsReq> _parser = new MessageParser<SetElfRestaurantPlayRecipeCsReq>(() => new SetElfRestaurantPlayRecipeCsReq());

	private UnknownFieldSet _unknownFields;

	public const int PJEJODHICDKFieldNumber = 3;

	private static readonly FieldCodec<uint> _repeated_pJEJODHICDK_codec = FieldCodec.ForUInt32(26u);

	private readonly RepeatedField<uint> pJEJODHICDK_ = new RepeatedField<uint>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<SetElfRestaurantPlayRecipeCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => SetElfRestaurantPlayRecipeCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<uint> PJEJODHICDK => pJEJODHICDK_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetElfRestaurantPlayRecipeCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetElfRestaurantPlayRecipeCsReq(SetElfRestaurantPlayRecipeCsReq other)
		: this()
	{
		pJEJODHICDK_ = other.pJEJODHICDK_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SetElfRestaurantPlayRecipeCsReq Clone()
	{
		return new SetElfRestaurantPlayRecipeCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as SetElfRestaurantPlayRecipeCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(SetElfRestaurantPlayRecipeCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!pJEJODHICDK_.Equals(other.pJEJODHICDK_))
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
		num ^= pJEJODHICDK_.GetHashCode();
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
		pJEJODHICDK_.WriteTo(ref output, _repeated_pJEJODHICDK_codec);
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
		num += pJEJODHICDK_.CalculateSize(_repeated_pJEJODHICDK_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(SetElfRestaurantPlayRecipeCsReq other)
	{
		if (other != null)
		{
			pJEJODHICDK_.Add(other.pJEJODHICDK_);
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
			if (num != 24 && num != 26)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				pJEJODHICDK_.AddEntriesFrom(ref input, _repeated_pJEJODHICDK_codec);
			}
		}
	}
}
