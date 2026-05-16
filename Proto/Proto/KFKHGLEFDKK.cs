using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class KFKHGLEFDKK : IMessage<KFKHGLEFDKK>, IMessage, IEquatable<KFKHGLEFDKK>, IDeepCloneable<KFKHGLEFDKK>, IBufferMessage
{
	private static readonly MessageParser<KFKHGLEFDKK> _parser = new MessageParser<KFKHGLEFDKK>(() => new KFKHGLEFDKK());

	private UnknownFieldSet _unknownFields;

	public const int DOKHAJLHKOOFieldNumber = 1;

	private FFNBJBNDFEK dOKHAJLHKOO_;

	public const int MessageDatasFieldNumber = 2;

	private static readonly FieldCodec<PMNGJCDCGMM> _repeated_messageDatas_codec = FieldCodec.ForMessage(18u, PMNGJCDCGMM.Parser);

	private readonly RepeatedField<PMNGJCDCGMM> messageDatas_ = new RepeatedField<PMNGJCDCGMM>();

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<KFKHGLEFDKK> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => KFKHGLEFDKKReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FFNBJBNDFEK DOKHAJLHKOO
	{
		get
		{
			return dOKHAJLHKOO_;
		}
		set
		{
			dOKHAJLHKOO_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<PMNGJCDCGMM> MessageDatas => messageDatas_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKHGLEFDKK()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKHGLEFDKK(KFKHGLEFDKK other)
		: this()
	{
		dOKHAJLHKOO_ = ((other.dOKHAJLHKOO_ != null) ? other.dOKHAJLHKOO_.Clone() : null);
		messageDatas_ = other.messageDatas_.Clone();
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public KFKHGLEFDKK Clone()
	{
		return new KFKHGLEFDKK(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as KFKHGLEFDKK);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(KFKHGLEFDKK other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(DOKHAJLHKOO, other.DOKHAJLHKOO))
		{
			return false;
		}
		if (!messageDatas_.Equals(other.messageDatas_))
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
		if (dOKHAJLHKOO_ != null)
		{
			num ^= DOKHAJLHKOO.GetHashCode();
		}
		num ^= messageDatas_.GetHashCode();
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
		if (dOKHAJLHKOO_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(DOKHAJLHKOO);
		}
		messageDatas_.WriteTo(ref output, _repeated_messageDatas_codec);
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
		if (dOKHAJLHKOO_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(DOKHAJLHKOO);
		}
		num += messageDatas_.CalculateSize(_repeated_messageDatas_codec);
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(KFKHGLEFDKK other)
	{
		if (other == null)
		{
			return;
		}
		if (other.dOKHAJLHKOO_ != null)
		{
			if (dOKHAJLHKOO_ == null)
			{
				DOKHAJLHKOO = new FFNBJBNDFEK();
			}
			DOKHAJLHKOO.MergeFrom(other.DOKHAJLHKOO);
		}
		messageDatas_.Add(other.messageDatas_);
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 10u:
				if (dOKHAJLHKOO_ == null)
				{
					DOKHAJLHKOO = new FFNBJBNDFEK();
				}
				input.ReadMessage(DOKHAJLHKOO);
				break;
			case 18u:
				messageDatas_.AddEntriesFrom(ref input, _repeated_messageDatas_codec);
				break;
			}
		}
	}
}
