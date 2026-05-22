using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class IdleLiveDressSpecialEquipCsReq : IMessage<IdleLiveDressSpecialEquipCsReq>, IMessage, IEquatable<IdleLiveDressSpecialEquipCsReq>, IDeepCloneable<IdleLiveDressSpecialEquipCsReq>, IBufferMessage
{
	private static readonly MessageParser<IdleLiveDressSpecialEquipCsReq> _parser = new MessageParser<IdleLiveDressSpecialEquipCsReq>(() => new IdleLiveDressSpecialEquipCsReq());

	private UnknownFieldSet _unknownFields;

	public const int CPOMNGJDBCLFieldNumber = 4;

	private static readonly FieldCodec<GKDEKJKOIJN> _repeated_cPOMNGJDBCL_codec = FieldCodec.ForMessage(34u, GKDEKJKOIJN.Parser);

	private readonly RepeatedField<GKDEKJKOIJN> cPOMNGJDBCL_ = new RepeatedField<GKDEKJKOIJN>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<IdleLiveDressSpecialEquipCsReq> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => IdleLiveDressSpecialEquipCsReqReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<GKDEKJKOIJN> CPOMNGJDBCL => cPOMNGJDBCL_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveDressSpecialEquipCsReq()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveDressSpecialEquipCsReq(IdleLiveDressSpecialEquipCsReq other)
		: this()
	{
		cPOMNGJDBCL_ = other.cPOMNGJDBCL_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public IdleLiveDressSpecialEquipCsReq Clone()
	{
		return new IdleLiveDressSpecialEquipCsReq(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as IdleLiveDressSpecialEquipCsReq);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(IdleLiveDressSpecialEquipCsReq other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!cPOMNGJDBCL_.Equals(other.cPOMNGJDBCL_))
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
		num ^= cPOMNGJDBCL_.GetHashCode();
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
		cPOMNGJDBCL_.WriteTo(ref output, _repeated_cPOMNGJDBCL_codec);
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
		num += cPOMNGJDBCL_.CalculateSize(_repeated_cPOMNGJDBCL_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(IdleLiveDressSpecialEquipCsReq other)
	{
		if (other != null)
		{
			cPOMNGJDBCL_.Add(other.cPOMNGJDBCL_);
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
			if (num != 34)
			{
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
			}
			else
			{
				cPOMNGJDBCL_.AddEntriesFrom(ref input, _repeated_cPOMNGJDBCL_codec);
			}
		}
	}
}
