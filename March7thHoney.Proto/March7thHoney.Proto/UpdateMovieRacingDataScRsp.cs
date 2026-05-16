using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

[DebuggerDisplay("{ToString(),nq}")]
public sealed class UpdateMovieRacingDataScRsp : IMessage<UpdateMovieRacingDataScRsp>, IMessage, IEquatable<UpdateMovieRacingDataScRsp>, IDeepCloneable<UpdateMovieRacingDataScRsp>, IBufferMessage
{
	private static readonly MessageParser<UpdateMovieRacingDataScRsp> _parser = new MessageParser<UpdateMovieRacingDataScRsp>(() => new UpdateMovieRacingDataScRsp());

	private UnknownFieldSet _unknownFields;

	public const int RetcodeFieldNumber = 8;

	private uint retcode_;

	public const int IMCEKFOOKHCFieldNumber = 10;

	private BNIGIAJOPGC iMCEKFOOKHC_;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<UpdateMovieRacingDataScRsp> Parser => _parser;

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor => UpdateMovieRacingDataScRspReflection.Descriptor.MessageTypes[0];

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	MessageDescriptor IMessage.Descriptor => Descriptor;

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
	public BNIGIAJOPGC IMCEKFOOKHC
	{
		get
		{
			return iMCEKFOOKHC_;
		}
		set
		{
			iMCEKFOOKHC_ = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataScRsp()
	{
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataScRsp(UpdateMovieRacingDataScRsp other)
		: this()
	{
		retcode_ = other.retcode_;
		iMCEKFOOKHC_ = ((other.iMCEKFOOKHC_ != null) ? other.iMCEKFOOKHC_.Clone() : null);
		_unknownFields = UnknownFieldSet.Clone(other._unknownFields);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public UpdateMovieRacingDataScRsp Clone()
	{
		return new UpdateMovieRacingDataScRsp(this);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return Equals(other as UpdateMovieRacingDataScRsp);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(UpdateMovieRacingDataScRsp other)
	{
		if (other == null)
		{
			return false;
		}
		if (other == this)
		{
			return true;
		}
		if (Retcode != other.Retcode)
		{
			return false;
		}
		if (!object.Equals(IMCEKFOOKHC, other.IMCEKFOOKHC))
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
		if (Retcode != 0)
		{
			num ^= Retcode.GetHashCode();
		}
		if (iMCEKFOOKHC_ != null)
		{
			num ^= IMCEKFOOKHC.GetHashCode();
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
		if (Retcode != 0)
		{
			output.WriteRawTag(64);
			output.WriteUInt32(Retcode);
		}
		if (iMCEKFOOKHC_ != null)
		{
			output.WriteRawTag(82);
			output.WriteMessage(IMCEKFOOKHC);
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
		if (Retcode != 0)
		{
			num += 1 + CodedOutputStream.ComputeUInt32Size(Retcode);
		}
		if (iMCEKFOOKHC_ != null)
		{
			num += 1 + CodedOutputStream.ComputeMessageSize(IMCEKFOOKHC);
		}
		if (_unknownFields != null)
		{
			num += _unknownFields.CalculateSize();
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(UpdateMovieRacingDataScRsp other)
	{
		if (other == null)
		{
			return;
		}
		if (other.Retcode != 0)
		{
			Retcode = other.Retcode;
		}
		if (other.iMCEKFOOKHC_ != null)
		{
			if (iMCEKFOOKHC_ == null)
			{
				IMCEKFOOKHC = new BNIGIAJOPGC();
			}
			IMCEKFOOKHC.MergeFrom(other.IMCEKFOOKHC);
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
			case 64u:
				Retcode = input.ReadUInt32();
				break;
			case 82u:
				if (iMCEKFOOKHC_ == null)
				{
					IMCEKFOOKHC = new BNIGIAJOPGC();
				}
				input.ReadMessage(IMCEKFOOKHC);
				break;
			}
		}
	}
}
