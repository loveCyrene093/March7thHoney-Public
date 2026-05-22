using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class MonopolyAcceptQuizScRsp : IMessage<MonopolyAcceptQuizScRsp>, IMessage, IEquatable<MonopolyAcceptQuizScRsp>, IDeepCloneable<MonopolyAcceptQuizScRsp>, IBufferMessage
{
	private static readonly MessageParser<MonopolyAcceptQuizScRsp> _parser = new MessageParser<MonopolyAcceptQuizScRsp>(() => new MonopolyAcceptQuizScRsp());

	private UnknownFieldSet _unknownFields;

	public const int MNCFNIEHMKKFieldNumber = 4;

	private JCADEHNDGLF mNCFNIEHMKK_;

	public const int RetcodeFieldNumber = 6;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MonopolyAcceptQuizScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => MonopolyAcceptQuizScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JCADEHNDGLF MNCFNIEHMKK
	{
		get
		{
			return mNCFNIEHMKK_;
		}
		set
		{
			mNCFNIEHMKK_ = value;
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
	public MonopolyAcceptQuizScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyAcceptQuizScRsp(MonopolyAcceptQuizScRsp other)
		: this()
	{
		mNCFNIEHMKK_ = ((other.mNCFNIEHMKK_ != null) ? other.mNCFNIEHMKK_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MonopolyAcceptQuizScRsp Clone()
	{
		return new MonopolyAcceptQuizScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as MonopolyAcceptQuizScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MonopolyAcceptQuizScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(MNCFNIEHMKK, other.MNCFNIEHMKK))
		{
			return false;
		}
		if (Retcode != other.Retcode)
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
		if (mNCFNIEHMKK_ != null)
		{
			num ^= MNCFNIEHMKK.GetHashCode();
		}
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
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
		if (mNCFNIEHMKK_ != null)
		{
			output.WriteRawTag(34);
			output.WriteMessage(MNCFNIEHMKK);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(48);
			output.WriteUInt32(Retcode);
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
		if (mNCFNIEHMKK_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(MNCFNIEHMKK);
		}
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MonopolyAcceptQuizScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.mNCFNIEHMKK_ != null)
		{
			if (mNCFNIEHMKK_ == null)
			{
				MNCFNIEHMKK = new JCADEHNDGLF();
			}
			MNCFNIEHMKK.MergeFrom(other.MNCFNIEHMKK);
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
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
			switch (num)
			{
			default:
				_unknownFields = UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
				break;
			case 34u:
				if (mNCFNIEHMKK_ == null)
				{
					MNCFNIEHMKK = new JCADEHNDGLF();
				}
				input.ReadMessage(MNCFNIEHMKK);
				break;
			case 48u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
