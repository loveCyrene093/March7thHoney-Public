using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class ChooseBoxingClubStageOptionalBuffScRsp : IMessage<ChooseBoxingClubStageOptionalBuffScRsp>, IMessage, IEquatable<ChooseBoxingClubStageOptionalBuffScRsp>, IDeepCloneable<ChooseBoxingClubStageOptionalBuffScRsp>, IBufferMessage
{
	private static readonly MessageParser<ChooseBoxingClubStageOptionalBuffScRsp> _parser = new MessageParser<ChooseBoxingClubStageOptionalBuffScRsp>(() => new ChooseBoxingClubStageOptionalBuffScRsp());

	private UnknownFieldSet _unknownFields;

	public const int OPCGNJMGJDEFieldNumber = 1;

	private OOMINGEFPAF oPCGNJMGJDE_;

	public const int RetcodeFieldNumber = 14;

	private uint retcode_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ChooseBoxingClubStageOptionalBuffScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => ChooseBoxingClubStageOptionalBuffScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OOMINGEFPAF OPCGNJMGJDE
	{
		get
		{
			return oPCGNJMGJDE_;
		}
		set
		{
			oPCGNJMGJDE_ = value;
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
	public ChooseBoxingClubStageOptionalBuffScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubStageOptionalBuffScRsp(ChooseBoxingClubStageOptionalBuffScRsp other)
		: this()
	{
		oPCGNJMGJDE_ = ((other.oPCGNJMGJDE_ != null) ? other.oPCGNJMGJDE_.Clone() : null);
		retcode_ = other.retcode_;
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ChooseBoxingClubStageOptionalBuffScRsp Clone()
	{
		return new ChooseBoxingClubStageOptionalBuffScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as ChooseBoxingClubStageOptionalBuffScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ChooseBoxingClubStageOptionalBuffScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (!object.Equals(OPCGNJMGJDE, other.OPCGNJMGJDE))
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
		if (oPCGNJMGJDE_ != null)
		{
			num ^= OPCGNJMGJDE.GetHashCode();
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
		if (oPCGNJMGJDE_ != null)
		{
			output.WriteRawTag(10);
			output.WriteMessage(OPCGNJMGJDE);
		}
		if (Retcode != 0)
		{
			output.WriteRawTag(112);
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
		if (oPCGNJMGJDE_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(OPCGNJMGJDE);
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
	public void MergeFrom(ChooseBoxingClubStageOptionalBuffScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.oPCGNJMGJDE_ != null)
		{
			if (oPCGNJMGJDE_ == null)
			{
				OPCGNJMGJDE = new OOMINGEFPAF();
			}
			OPCGNJMGJDE.MergeFrom(other.OPCGNJMGJDE);
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
			case 10u:
				if (oPCGNJMGJDE_ == null)
				{
					OPCGNJMGJDE = new OOMINGEFPAF();
				}
				input.ReadMessage(OPCGNJMGJDE);
				break;
			case 112u:
				Retcode = input.ReadUInt32();
				break;
			}
		}
	}
}
